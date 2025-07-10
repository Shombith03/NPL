using UnityEngine;
using UnityEngine.InputSystem;
using CricketManager.Data;

namespace CricketManager.Input
{
    /// <summary>
    /// Singleton providing access to input actions for the UI.
    /// </summary>
    public class InputService : MonoBehaviour
    {
        public static InputService Instance { get; private set; }

        public CricketManagerInputActions Actions { get; private set; }
        public PlayerInput PlayerInput { get; private set; }

        [Tooltip("Input actions asset used by PlayerInput")] 
        [SerializeField] private InputActionsSO inputActions;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            PlayerInput = gameObject.AddComponent<PlayerInput>();
            if (inputActions != null)
            {
                PlayerInput.actions = Instantiate(inputActions.actions);
                PlayerInput.defaultActionMap = "UI";
            }

            Actions = new CricketManagerInputActions(PlayerInput.actions);
            Actions.Enable();
        }
    }
}
