using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace WarGames_Defcon_1.Code.Scripts.Input {
    public partial class @Input : IInputActionCollection2, IDisposable {
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""WarGames Defcon 1"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8caea8bd-fdc6-4225-89a2-1b83e4ffb48a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""77a19cc4-04f6-468c-9397-91369a1e2913"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""fe580224-3cda-43cf-83e4-5ce4f50b965e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Main Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e230a516-2d1e-4dd6-841e-799112a9373f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Alternate Attack"",
                    ""type"": ""Button"",
                    ""id"": ""d7a7306d-0578-4a4d-8c6f-280af6821969"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Change View"",
                    ""type"": ""Button"",
                    ""id"": ""05fe518d-d409-40f4-abb0-fcc911ef10cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Change Unit"",
                    ""type"": ""Button"",
                    ""id"": ""c976a1b9-4875-4c16-b9c7-1e5fbe60c9a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Command Menu"",
                    ""type"": ""Button"",
                    ""id"": ""10b3fbf0-0867-4cb2-ade4-2dac29ad8643"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause Menu"",
                    ""type"": ""Button"",
                    ""id"": ""30762783-dc82-4aab-9497-a3914613cb2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Settings Menu"",
                    ""type"": ""Button"",
                    ""id"": ""ccc02c0e-ac4f-4e0f-9432-818057c5ba5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Main Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a50ce675-92b1-40a8-8fd5-cf107f4292a8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Alternate Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4027f2bc-fab4-4824-b5ad-8a221ffe0c37"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Unit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e196edbe-60a9-44f8-833c-b7c23df57864"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Settings Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1e5c14d-067d-4751-87b1-79707d4adcec"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f6d1c0-08e5-46d7-91a4-a8459a653b7b"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""617b9678-cb5c-44c1-80b0-7a8be62cb610"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2be0c7bb-0053-4dbd-8c26-2320d1c6e551"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3b0effb-446e-4d95-bb41-6122be2f6dea"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6dac6c60-5cb2-4251-b025-3eb9df933f74"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""91261be4-d2dc-45be-8619-79bacdfae9fe"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd6ea124-4c3e-4e6e-8f33-67eac46bdf43"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""3d64b0e9-c40c-4a8a-b69d-833bda0746fc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""ab1b7590-2278-4cd8-96cb-b201d0c6a85d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""209abbec-c183-435a-8dbe-5070a5e5c6b0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3ffe78c6-aa6d-466c-a3e4-9fb0f06f98a9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8a309b8b-2fa2-4456-9c3b-8362b0d222f1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_MainAttack = m_Player.FindAction("Main Attack", throwIfNotFound: true);
        m_Player_AlternateAttack = m_Player.FindAction("Alternate Attack", throwIfNotFound: true);
        m_Player_ChangeView = m_Player.FindAction("Change View", throwIfNotFound: true);
        m_Player_ChangeUnit = m_Player.FindAction("Change Unit", throwIfNotFound: true);
        m_Player_CommandMenu = m_Player.FindAction("Command Menu", throwIfNotFound: true);
        m_Player_PauseMenu = m_Player.FindAction("Pause Menu", throwIfNotFound: true);
        m_Player_SettingsMenu = m_Player.FindAction("Settings Menu", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_MainAttack;
    private readonly InputAction m_Player_AlternateAttack;
    private readonly InputAction m_Player_ChangeView;
    private readonly InputAction m_Player_ChangeUnit;
    private readonly InputAction m_Player_CommandMenu;
    private readonly InputAction m_Player_PauseMenu;
    private readonly InputAction m_Player_SettingsMenu;
    public struct PlayerActions
    {
        private @Input m_Wrapper;
        public PlayerActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @MainAttack => m_Wrapper.m_Player_MainAttack;
        public InputAction @AlternateAttack => m_Wrapper.m_Player_AlternateAttack;
        public InputAction @ChangeView => m_Wrapper.m_Player_ChangeView;
        public InputAction @ChangeUnit => m_Wrapper.m_Player_ChangeUnit;
        public InputAction @CommandMenu => m_Wrapper.m_Player_CommandMenu;
        public InputAction @PauseMenu => m_Wrapper.m_Player_PauseMenu;
        public InputAction @SettingsMenu => m_Wrapper.m_Player_SettingsMenu;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @MainAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                @MainAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                @MainAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMainAttack;
                @AlternateAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                @AlternateAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                @AlternateAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlternateAttack;
                @ChangeView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                @ChangeView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                @ChangeView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeView;
                @ChangeUnit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                @ChangeUnit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                @ChangeUnit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeUnit;
                @CommandMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                @CommandMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                @CommandMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommandMenu;
                @PauseMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @SettingsMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
                @SettingsMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
                @SettingsMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSettingsMenu;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @MainAttack.started += instance.OnMainAttack;
                @MainAttack.performed += instance.OnMainAttack;
                @MainAttack.canceled += instance.OnMainAttack;
                @AlternateAttack.started += instance.OnAlternateAttack;
                @AlternateAttack.performed += instance.OnAlternateAttack;
                @AlternateAttack.canceled += instance.OnAlternateAttack;
                @ChangeView.started += instance.OnChangeView;
                @ChangeView.performed += instance.OnChangeView;
                @ChangeView.canceled += instance.OnChangeView;
                @ChangeUnit.started += instance.OnChangeUnit;
                @ChangeUnit.performed += instance.OnChangeUnit;
                @ChangeUnit.canceled += instance.OnChangeUnit;
                @CommandMenu.started += instance.OnCommandMenu;
                @CommandMenu.performed += instance.OnCommandMenu;
                @CommandMenu.canceled += instance.OnCommandMenu;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @SettingsMenu.started += instance.OnSettingsMenu;
                @SettingsMenu.performed += instance.OnSettingsMenu;
                @SettingsMenu.canceled += instance.OnSettingsMenu;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnMainAttack(InputAction.CallbackContext context);
        void OnAlternateAttack(InputAction.CallbackContext context);
        void OnChangeView(InputAction.CallbackContext context);
        void OnChangeUnit(InputAction.CallbackContext context);
        void OnCommandMenu(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnSettingsMenu(InputAction.CallbackContext context);
    }
}
}