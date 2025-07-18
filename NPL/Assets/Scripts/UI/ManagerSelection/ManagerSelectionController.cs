using System.Collections.Generic;
using UnityEngine;
using CricketManager.Data;

namespace CricketManager.UI.ManagerSelection
{
    /// <summary>
    /// Controller handling manager selection logic.
    /// </summary>
    public class ManagerSelectionController : MonoBehaviour
    {
        [SerializeField] private ManagerSelectionView view;
        // TODO: Load manager ScriptableObjects from a database or Resources folder
        [SerializeField] private List<ManagerSO> managers = new();

        private int _currentIndex;

        private void Awake()
        {
            view.OnNavigate += HandleNavigate;
            view.OnSelect += HandleSelect;
            view.Setup(managers);
            if (managers.Count > 0)
            {
                view.ShowManager(managers[_currentIndex]);
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
                _currentIndex = (_currentIndex + 1) % managers.Count;
            }
            else if (input.x < -0.1f)
            {
                _currentIndex = (_currentIndex - 1 + managers.Count) % managers.Count;
            }

            if (managers.Count > 0)
            {
                view.ShowManager(managers[_currentIndex]);
            }
        }

        private void HandleSelect()
        {
            Debug.Log($"Selected manager: {managers[_currentIndex].managerName}");
        }
    }
}
