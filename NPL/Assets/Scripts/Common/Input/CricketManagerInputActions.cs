using UnityEngine;
using UnityEngine.InputSystem;

namespace CricketManager.Input
{
    /// <summary>
    /// Minimal wrapper for input actions used by the sample. In a real project
    /// this class would be generated from a .inputactions asset.
    /// </summary>
    public class CricketManagerInputActions
    {
        public InputActionAsset asset { get; }
        public UIActions UI { get; }

        public CricketManagerInputActions(InputActionAsset actions = null)
        {
            if (actions != null)
            {
                asset = actions;
            }
            else
            {
                asset = ScriptableObject.CreateInstance<InputActionAsset>();
                var uiMap = new InputActionMap("UI");
                var navigate = uiMap.AddAction("Navigate", binding: "<Gamepad>/leftStick");
                navigate.AddCompositeBinding("2DVector")
                    .With("Up", "<Keyboard>/w")
                    .With("Down", "<Keyboard>/s")
                    .With("Left", "<Keyboard>/a")
                    .With("Right", "<Keyboard>/d");
                var submit = uiMap.AddAction("Submit", binding: "<Keyboard>/enter");
                var cancel = uiMap.AddAction("Cancel", binding: "<Keyboard>/escape");
                asset.AddActionMap(uiMap);
            }
            UI = new UIActions(this);
            asset.Enable();
        }

        public class UIActions
        {
            private readonly CricketManagerInputActions _wrapper;
            public UIActions(CricketManagerInputActions wrapper) { _wrapper = wrapper; }
            public InputAction Navigate => _wrapper.asset.FindAction("UI/Navigate", true);
            public InputAction Submit => _wrapper.asset.FindAction("UI/Submit", true);
            public InputAction Cancel => _wrapper.asset.FindAction("UI/Cancel", true);
        }

        public void Enable() => asset.Enable();
        public void Disable() => asset.Disable();
    }
}
