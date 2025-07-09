using UnityEngine;

namespace CricketManager.Input
{
    /// <summary>
    /// Singleton providing access to input actions for the UI.
    /// </summary>
    public class InputService : MonoBehaviour
    {
        public static InputService Instance { get; private set; }

        public CricketManagerInputActions Actions { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            Actions = new CricketManagerInputActions();
            Actions.Enable();
        }
    }
}
