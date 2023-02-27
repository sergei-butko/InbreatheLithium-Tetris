//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/UserInputs/UserControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace UserInputs
{
    public partial class @UserControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @UserControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserControls"",
    ""maps"": [
        {
            ""name"": ""Tetris"",
            ""id"": ""7c352611-3e56-4a7d-8383-81c0a8b13109"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""da51c835-10c3-4b39-8363-888340358dae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d2ba4d30-e335-4d29-932f-4513052aec3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""e2b00d7c-4f97-41cb-a7db-3c2d07ef36c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2c73c1d9-e75b-48ce-a81c-0ef04edb3cd4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c68f0031-c1dd-4d02-9d48-1dbfef25daca"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""066f2e6f-dbd5-4b5d-813e-e538002d30c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7f8c54f-ee4f-4efe-b28f-d896d995b79e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53a0d4ad-ea46-41e4-9655-5ee6d0323795"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Tetris
            m_Tetris = asset.FindActionMap("Tetris", throwIfNotFound: true);
            m_Tetris_MoveRight = m_Tetris.FindAction("MoveRight", throwIfNotFound: true);
            m_Tetris_MoveLeft = m_Tetris.FindAction("MoveLeft", throwIfNotFound: true);
            m_Tetris_Rotate = m_Tetris.FindAction("Rotate", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Tetris
        private readonly InputActionMap m_Tetris;
        private ITetrisActions m_TetrisActionsCallbackInterface;
        private readonly InputAction m_Tetris_MoveRight;
        private readonly InputAction m_Tetris_MoveLeft;
        private readonly InputAction m_Tetris_Rotate;
        public struct TetrisActions
        {
            private @UserControls m_Wrapper;
            public TetrisActions(@UserControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveRight => m_Wrapper.m_Tetris_MoveRight;
            public InputAction @MoveLeft => m_Wrapper.m_Tetris_MoveLeft;
            public InputAction @Rotate => m_Wrapper.m_Tetris_Rotate;
            public InputActionMap Get() { return m_Wrapper.m_Tetris; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TetrisActions set) { return set.Get(); }
            public void SetCallbacks(ITetrisActions instance)
            {
                if (m_Wrapper.m_TetrisActionsCallbackInterface != null)
                {
                    @MoveRight.started -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveRight;
                    @MoveRight.performed -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveRight;
                    @MoveRight.canceled -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveRight;
                    @MoveLeft.started -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.performed -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.canceled -= m_Wrapper.m_TetrisActionsCallbackInterface.OnMoveLeft;
                    @Rotate.started -= m_Wrapper.m_TetrisActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_TetrisActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_TetrisActionsCallbackInterface.OnRotate;
                }
                m_Wrapper.m_TetrisActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveRight.started += instance.OnMoveRight;
                    @MoveRight.performed += instance.OnMoveRight;
                    @MoveRight.canceled += instance.OnMoveRight;
                    @MoveLeft.started += instance.OnMoveLeft;
                    @MoveLeft.performed += instance.OnMoveLeft;
                    @MoveLeft.canceled += instance.OnMoveLeft;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                }
            }
        }
        public TetrisActions @Tetris => new TetrisActions(this);
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        public interface ITetrisActions
        {
            void OnMoveRight(InputAction.CallbackContext context);
            void OnMoveLeft(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
        }
    }
}
