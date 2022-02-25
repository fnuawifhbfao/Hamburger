//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/InputTest/InputTest0.inputactions
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

public partial class @InputTest0 : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputTest0()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputTest0"",
    ""maps"": [
        {
            ""name"": ""Man"",
            ""id"": ""3eb473b4-c512-420a-b5ec-7880648f10d8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""858e0915-f380-44a4-8dc0-426d39fb0a78"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""d70bb13a-e196-407b-a56b-5061dc994b23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MinusAccelerate"",
                    ""type"": ""Value"",
                    ""id"": ""9c4a3722-70fa-4261-82f9-3b195d8ecfbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crash"",
                    ""type"": ""Button"",
                    ""id"": ""aefcabf5-ad79-41c9-a993-f169f2360f6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9fbda3a2-4829-45de-9195-08f74fb8c3e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c88780bc-e4cf-4a0f-bb02-9b0ecf85f257"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19fc1241-0f23-4def-a05a-f9b4d1d4ee1a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42e3ed4b-be2f-4f97-b937-3f6cf578a890"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1104e807-1c1e-47d6-9e0a-e3b3f601874c"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64253e13-90bf-4967-9fc3-0abe92266ecc"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""11850d3d-b4d9-4e8c-9797-5ee788e93c40"",
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
                    ""id"": ""58256cd0-188c-4b2a-b1d9-ebceb0476d6f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""721b25fc-8e79-475d-9af7-3694a052c514"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""2c9b00c9-b606-4aee-8db1-f07f81bfccfd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""4f05523a-4d52-4258-8f12-c8c2f26818e4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2d88358-5f69-43ea-a0a3-b02a744238b2"",
                    ""path"": ""<SwitchProControllerHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c2240f45-c65f-4bcc-b95d-1ce436e47928"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7618a6cb-e68c-4db0-b62a-9398e7c0aa82"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2887f28-c72d-429b-8b00-64f319bf4ac7"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad550d46-56ba-4c37-9065-3d74812cc40a"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""MinusAccelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Man1"",
            ""id"": ""5ff55211-8c02-4740-8fd8-03663cfae41a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a0c9aee4-692d-4dda-9262-92ebd1dfcb52"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""d92aca10-718c-4d78-bfaf-08b0584a24a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crash"",
                    ""type"": ""Button"",
                    ""id"": ""1085655d-a560-4e24-b257-a40e04afcccb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e43d4d84-ba13-4924-be40-748686d9be8c"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0525308d-a81c-472d-a17a-43b5bef8dbe7"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67ad98b6-8724-4615-9cc2-c7de0d090369"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""296d7b9a-a420-44fd-843d-ef077ee24a77"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Xbox"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdbc23a9-2f30-4afe-a5a1-1cd9573c4e3a"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""369707e3-8efc-4461-a9f3-f0c0aef4a452"",
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
                    ""id"": ""2834ce6c-403a-4c92-99c8-04af372a840b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""e32e3937-edbf-47ef-994e-c88738ed6cef"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""46673f23-ca77-4a95-bb46-e36ad0c9e878"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""786ef216-4a4d-4f28-aee8-7af031f1876e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""90351a3b-1379-4800-89bb-3f9db37decb2"",
                    ""path"": ""<SwitchProControllerHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
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
        },
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Man
        m_Man = asset.FindActionMap("Man", throwIfNotFound: true);
        m_Man_Move = m_Man.FindAction("Move", throwIfNotFound: true);
        m_Man_Accelerate = m_Man.FindAction("Accelerate", throwIfNotFound: true);
        m_Man_MinusAccelerate = m_Man.FindAction("MinusAccelerate", throwIfNotFound: true);
        m_Man_Crash = m_Man.FindAction("Crash", throwIfNotFound: true);
        m_Man_Jump = m_Man.FindAction("Jump", throwIfNotFound: true);
        // Man1
        m_Man1 = asset.FindActionMap("Man1", throwIfNotFound: true);
        m_Man1_Move = m_Man1.FindAction("Move", throwIfNotFound: true);
        m_Man1_Accelerate = m_Man1.FindAction("Accelerate", throwIfNotFound: true);
        m_Man1_Crash = m_Man1.FindAction("Crash", throwIfNotFound: true);
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

    // Man
    private readonly InputActionMap m_Man;
    private IManActions m_ManActionsCallbackInterface;
    private readonly InputAction m_Man_Move;
    private readonly InputAction m_Man_Accelerate;
    private readonly InputAction m_Man_MinusAccelerate;
    private readonly InputAction m_Man_Crash;
    private readonly InputAction m_Man_Jump;
    public struct ManActions
    {
        private @InputTest0 m_Wrapper;
        public ManActions(@InputTest0 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Man_Move;
        public InputAction @Accelerate => m_Wrapper.m_Man_Accelerate;
        public InputAction @MinusAccelerate => m_Wrapper.m_Man_MinusAccelerate;
        public InputAction @Crash => m_Wrapper.m_Man_Crash;
        public InputAction @Jump => m_Wrapper.m_Man_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Man; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManActions set) { return set.Get(); }
        public void SetCallbacks(IManActions instance)
        {
            if (m_Wrapper.m_ManActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ManActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ManActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ManActionsCallbackInterface.OnMove;
                @Accelerate.started -= m_Wrapper.m_ManActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ManActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ManActionsCallbackInterface.OnAccelerate;
                @MinusAccelerate.started -= m_Wrapper.m_ManActionsCallbackInterface.OnMinusAccelerate;
                @MinusAccelerate.performed -= m_Wrapper.m_ManActionsCallbackInterface.OnMinusAccelerate;
                @MinusAccelerate.canceled -= m_Wrapper.m_ManActionsCallbackInterface.OnMinusAccelerate;
                @Crash.started -= m_Wrapper.m_ManActionsCallbackInterface.OnCrash;
                @Crash.performed -= m_Wrapper.m_ManActionsCallbackInterface.OnCrash;
                @Crash.canceled -= m_Wrapper.m_ManActionsCallbackInterface.OnCrash;
                @Jump.started -= m_Wrapper.m_ManActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ManActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ManActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ManActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @MinusAccelerate.started += instance.OnMinusAccelerate;
                @MinusAccelerate.performed += instance.OnMinusAccelerate;
                @MinusAccelerate.canceled += instance.OnMinusAccelerate;
                @Crash.started += instance.OnCrash;
                @Crash.performed += instance.OnCrash;
                @Crash.canceled += instance.OnCrash;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ManActions @Man => new ManActions(this);

    // Man1
    private readonly InputActionMap m_Man1;
    private IMan1Actions m_Man1ActionsCallbackInterface;
    private readonly InputAction m_Man1_Move;
    private readonly InputAction m_Man1_Accelerate;
    private readonly InputAction m_Man1_Crash;
    public struct Man1Actions
    {
        private @InputTest0 m_Wrapper;
        public Man1Actions(@InputTest0 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Man1_Move;
        public InputAction @Accelerate => m_Wrapper.m_Man1_Accelerate;
        public InputAction @Crash => m_Wrapper.m_Man1_Crash;
        public InputActionMap Get() { return m_Wrapper.m_Man1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Man1Actions set) { return set.Get(); }
        public void SetCallbacks(IMan1Actions instance)
        {
            if (m_Wrapper.m_Man1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Man1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Man1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Man1ActionsCallbackInterface.OnMove;
                @Accelerate.started -= m_Wrapper.m_Man1ActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_Man1ActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_Man1ActionsCallbackInterface.OnAccelerate;
                @Crash.started -= m_Wrapper.m_Man1ActionsCallbackInterface.OnCrash;
                @Crash.performed -= m_Wrapper.m_Man1ActionsCallbackInterface.OnCrash;
                @Crash.canceled -= m_Wrapper.m_Man1ActionsCallbackInterface.OnCrash;
            }
            m_Wrapper.m_Man1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Crash.started += instance.OnCrash;
                @Crash.performed += instance.OnCrash;
                @Crash.canceled += instance.OnCrash;
            }
        }
    }
    public Man1Actions @Man1 => new Man1Actions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    public interface IManActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnMinusAccelerate(InputAction.CallbackContext context);
        void OnCrash(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMan1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnCrash(InputAction.CallbackContext context);
    }
}
