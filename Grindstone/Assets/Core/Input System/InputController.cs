// GENERATED AUTOMATICALLY FROM 'Assets/Core/Input System/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Gameplay-controller"",
            ""id"": ""0c0c650b-4d0a-4c59-85eb-ebe39688878d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""48231b89-9b8a-46d7-b3c9-276607725a34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""57a43a49-6c33-4284-9f1c-9909843c2595"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""0e0bc2b6-325f-4a24-9ff7-1b0b45223f62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9a613c6a-79b8-4e6b-847b-31a99d73598f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1a3afe18-a32f-4d1f-8cca-b57ce9a2aac2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75cde413-2d00-42d9-afd1-2568fde551dc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b83bde3-152a-44dd-a023-1538b79974a5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0e28bba-5f9d-4f47-a8f8-a73fd7c0f52d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay-keyboard"",
            ""id"": ""fe1747f9-fd8b-40e6-9bcd-80ec0698c3af"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""75c27970-1c38-4fc6-92b1-8f531d95ce1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d22879fc-334d-4329-bfbe-03e5f9f87e3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""949b1fa2-a2a0-4a41-a586-814703aa4797"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f4e323b2-9013-4384-8baa-83f7e7ee4d11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a4dab519-462e-4827-821c-0e1020b79b95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9898f144-7e4c-42f3-acc9-f7b48745ecae"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eed9bb89-b29b-42c3-9327-5c4ed8ede938"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaa09455-44a1-4878-b515-4efc2d2dc4fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""850437ba-153d-49ee-9494-5dfa7bcc5f70"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d41edc6a-774e-406a-9cd8-b424dfaeb4bc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay-controller
        m_Gameplaycontroller = asset.FindActionMap("Gameplay-controller", throwIfNotFound: true);
        m_Gameplaycontroller_Jump = m_Gameplaycontroller.FindAction("Jump", throwIfNotFound: true);
        m_Gameplaycontroller_Move = m_Gameplaycontroller.FindAction("Move", throwIfNotFound: true);
        m_Gameplaycontroller_Attack = m_Gameplaycontroller.FindAction("Attack", throwIfNotFound: true);
        m_Gameplaycontroller_Pause = m_Gameplaycontroller.FindAction("Pause", throwIfNotFound: true);
        // Gameplay-keyboard
        m_Gameplaykeyboard = asset.FindActionMap("Gameplay-keyboard", throwIfNotFound: true);
        m_Gameplaykeyboard_Jump = m_Gameplaykeyboard.FindAction("Jump", throwIfNotFound: true);
        m_Gameplaykeyboard_MoveLeft = m_Gameplaykeyboard.FindAction("MoveLeft", throwIfNotFound: true);
        m_Gameplaykeyboard_MoveRight = m_Gameplaykeyboard.FindAction("MoveRight", throwIfNotFound: true);
        m_Gameplaykeyboard_Attack = m_Gameplaykeyboard.FindAction("Attack", throwIfNotFound: true);
        m_Gameplaykeyboard_Pause = m_Gameplaykeyboard.FindAction("Pause", throwIfNotFound: true);
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

    // Gameplay-controller
    private readonly InputActionMap m_Gameplaycontroller;
    private IGameplaycontrollerActions m_GameplaycontrollerActionsCallbackInterface;
    private readonly InputAction m_Gameplaycontroller_Jump;
    private readonly InputAction m_Gameplaycontroller_Move;
    private readonly InputAction m_Gameplaycontroller_Attack;
    private readonly InputAction m_Gameplaycontroller_Pause;
    public struct GameplaycontrollerActions
    {
        private @InputController m_Wrapper;
        public GameplaycontrollerActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplaycontroller_Jump;
        public InputAction @Move => m_Wrapper.m_Gameplaycontroller_Move;
        public InputAction @Attack => m_Wrapper.m_Gameplaycontroller_Attack;
        public InputAction @Pause => m_Wrapper.m_Gameplaycontroller_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplaycontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplaycontrollerActions set) { return set.Get(); }
        public void SetCallbacks(IGameplaycontrollerActions instance)
        {
            if (m_Wrapper.m_GameplaycontrollerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnAttack;
                @Pause.started -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplaycontrollerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplaycontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplaycontrollerActions @Gameplaycontroller => new GameplaycontrollerActions(this);

    // Gameplay-keyboard
    private readonly InputActionMap m_Gameplaykeyboard;
    private IGameplaykeyboardActions m_GameplaykeyboardActionsCallbackInterface;
    private readonly InputAction m_Gameplaykeyboard_Jump;
    private readonly InputAction m_Gameplaykeyboard_MoveLeft;
    private readonly InputAction m_Gameplaykeyboard_MoveRight;
    private readonly InputAction m_Gameplaykeyboard_Attack;
    private readonly InputAction m_Gameplaykeyboard_Pause;
    public struct GameplaykeyboardActions
    {
        private @InputController m_Wrapper;
        public GameplaykeyboardActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplaykeyboard_Jump;
        public InputAction @MoveLeft => m_Wrapper.m_Gameplaykeyboard_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Gameplaykeyboard_MoveRight;
        public InputAction @Attack => m_Wrapper.m_Gameplaykeyboard_Attack;
        public InputAction @Pause => m_Wrapper.m_Gameplaykeyboard_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplaykeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplaykeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IGameplaykeyboardActions instance)
        {
            if (m_Wrapper.m_GameplaykeyboardActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnJump;
                @MoveLeft.started -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnMoveRight;
                @Attack.started -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnAttack;
                @Pause.started -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplaykeyboardActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplaykeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplaykeyboardActions @Gameplaykeyboard => new GameplaykeyboardActions(this);
    public interface IGameplaycontrollerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IGameplaykeyboardActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
