using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using CricketManager.Data;
using CricketManager.Input;

namespace CricketManager.UI.TeamSelection
{
    /// <summary>
    /// View responsible for displaying and navigating teams.
    /// UI references must be assigned via the inspector.
    /// </summary>
    public class TeamSelectionView : MonoBehaviour, ITeamSelectionView
    {
        public event Action<Vector2> OnNavigate;
        public event Action OnSelect;

        [Header("UI References")]
        [Tooltip("Text element for displaying team name.")]
        [SerializeField] private TMP_Text teamNameText;
        [Tooltip("Image element for displaying team logo.")]
        [SerializeField] private Image teamLogoImage;
        [Tooltip("Text element for displaying league info.")]
        [SerializeField] private TMP_Text leagueText;

        private List<TeamSO> _teams;

        private void OnEnable()
        {
            var actions = InputService.Instance.Actions.UI;
            actions.Navigate.performed += OnNavigateInput;
            actions.Submit.performed += OnSubmitInput;
        }

        private void OnDisable()
        {
            var actions = InputService.Instance.Actions.UI;
            actions.Navigate.performed -= OnNavigateInput;
            actions.Submit.performed -= OnSubmitInput;
        }

        public void Setup(List<TeamSO> teams)
        {
            _teams = teams;
        }

        public void ShowTeam(TeamSO team)
        {
            if (teamNameText != null) teamNameText.text = team.teamName;
            if (teamLogoImage != null) teamLogoImage.sprite = team.teamLogo;
            if (leagueText != null) leagueText.text = team.leagueName;
        }

        private void OnNavigateInput(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
        {
            OnNavigate?.Invoke(ctx.ReadValue<Vector2>());
        }

        private void OnSubmitInput(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            OnSelect?.Invoke();
        }
    }
}
