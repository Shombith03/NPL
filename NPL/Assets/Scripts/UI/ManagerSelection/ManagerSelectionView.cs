using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using CricketManager.Data;
using CricketManager.Input;

namespace CricketManager.UI.ManagerSelection
{
    /// <summary>
    /// View responsible for displaying and navigating manager profiles.
    /// UI references must be assigned via the inspector.
    /// </summary>
    public class ManagerSelectionView : MonoBehaviour, IManagerSelectionView
    {
        public event Action<Vector2> OnNavigate;
        public event Action OnSelect;

        [Header("UI References")]
        [Tooltip("Text element for displaying manager name.")]
        [SerializeField] private TMP_Text managerNameText;
        [Tooltip("Image element for displaying manager avatar.")]
        [SerializeField] private Image avatarImage;
        [Tooltip("Text element for displaying manager bio.")]
        [SerializeField] private TMP_Text bioText;

        private List<ManagerSO> _managers;

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

        public void Setup(List<ManagerSO> managers)
        {
            _managers = managers;
        }

        public void ShowManager(ManagerSO manager)
        {
            if (managerNameText != null) managerNameText.text = manager.managerName;
            if (avatarImage != null) avatarImage.sprite = manager.avatar;
            if (bioText != null) bioText.text = manager.bio;
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
