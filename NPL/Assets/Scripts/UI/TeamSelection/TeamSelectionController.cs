using System.Collections.Generic;
using UnityEngine;
using CricketManager.Data;

namespace CricketManager.UI.TeamSelection
{
    /// <summary>
    /// Controller handling team selection logic.
    /// </summary>
    public class TeamSelectionController : MonoBehaviour
    {
        [SerializeField] private TeamSelectionView view;
        // TODO: Load team ScriptableObjects dynamically
        [SerializeField] private List<TeamSO> teams = new();

        private int _currentIndex;

        private void Awake()
        {
            view.OnNavigate += HandleNavigate;
            view.OnSelect += HandleSelect;
            view.Setup(teams);
            if (teams.Count > 0)
            {
                view.ShowTeam(teams[_currentIndex]);
            }
        }

        private void OnDestroy()
        {
            view.OnNavigate -= HandleNavigate;
            view.OnSelect -= HandleSelect;
        }

        private void HandleNavigate(Vector2 input)
        {
            if (input.x > 0.1f)
            {
                _currentIndex = (_currentIndex + 1) % teams.Count;
            }
            else if (input.x < -0.1f)
            {
                _currentIndex = (_currentIndex - 1 + teams.Count) % teams.Count;
            }

            if (teams.Count > 0)
            {
                view.ShowTeam(teams[_currentIndex]);
            }
        }

        private void HandleSelect()
        {
            Debug.Log($"Selected team: {teams[_currentIndex].teamName}");
        }
    }
}
