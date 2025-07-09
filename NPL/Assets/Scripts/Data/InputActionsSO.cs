using UnityEngine;
using UnityEngine.InputSystem;

namespace CricketManager.Data
{
    /// <summary>
    /// Holds a reference to a Unity InputActionAsset for input bindings.
    /// </summary>
    [CreateAssetMenu(fileName = "InputActions", menuName = "CricketManager/InputActions", order = 3)]
    public class InputActionsSO : ScriptableObject
    {
        public InputActionAsset actions;
    }
}
