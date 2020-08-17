// GENERATED AUTOMATICALLY FROM 'Assets/playerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerControls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""8e7a47e5-9fba-4501-ab40-7847f9507940"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""8889bd17-3db4-4125-89ad-1d28dd0554dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f2e703f7-0ce4-438d-a2bb-33c3bd35dcd8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9b68c7c4-9846-4d59-99da-d43269d39863"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""ba34d1e2-fb4c-4b12-9020-79533ff5984d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Value"",
                    ""id"": ""cb04058f-e328-4d1c-b6ff-6863bfeb47d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""circle"",
                    ""type"": ""Button"",
                    ""id"": ""6fa63827-9c47-4c8d-a894-82050ccfe681"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""space"",
                    ""type"": ""Button"",
                    ""id"": ""c47987a5-3230-47b6-a8de-e43836e728c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speak"",
                    ""type"": ""Button"",
                    ""id"": ""de430c7b-000b-4d06-8fcd-ffcf9974b0ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c699ef19-8058-4748-aab6-c12462280101"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af788cf9-7876-4b94-bc55-c51695540105"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17a5d194-b83a-4d5d-aa8a-fd951552e735"",
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
                    ""id"": ""7f6543f4-e1db-4895-aac9-4bcd34e878d2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""175a9751-2668-4440-b6e1-7fc22bc97ec3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b04a85da-f452-4ca3-a33e-53b485a26f43"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da8350cb-506b-43a8-8382-229ce5a0bd87"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a38904bc-44a8-4aa2-ac53-2639a353ce94"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_Movement = m_gameplay.FindAction("Movement", throwIfNotFound: true);
        m_gameplay_CameraMovement = m_gameplay.FindAction("Camera Movement", throwIfNotFound: true);
        m_gameplay_Jump = m_gameplay.FindAction("Jump", throwIfNotFound: true);
        m_gameplay_Pickup = m_gameplay.FindAction("Pickup", throwIfNotFound: true);
        m_gameplay_SpeedUp = m_gameplay.FindAction("SpeedUp", throwIfNotFound: true);
        m_gameplay_circle = m_gameplay.FindAction("circle", throwIfNotFound: true);
        m_gameplay_space = m_gameplay.FindAction("space", throwIfNotFound: true);
        m_gameplay_Speak = m_gameplay.FindAction("Speak", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_Movement;
    private readonly InputAction m_gameplay_CameraMovement;
    private readonly InputAction m_gameplay_Jump;
    private readonly InputAction m_gameplay_Pickup;
    private readonly InputAction m_gameplay_SpeedUp;
    private readonly InputAction m_gameplay_circle;
    private readonly InputAction m_gameplay_space;
    private readonly InputAction m_gameplay_Speak;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_gameplay_Movement;
        public InputAction @CameraMovement => m_Wrapper.m_gameplay_CameraMovement;
        public InputAction @Jump => m_Wrapper.m_gameplay_Jump;
        public InputAction @Pickup => m_Wrapper.m_gameplay_Pickup;
        public InputAction @SpeedUp => m_Wrapper.m_gameplay_SpeedUp;
        public InputAction @circle => m_Wrapper.m_gameplay_circle;
        public InputAction @space => m_Wrapper.m_gameplay_space;
        public InputAction @Speak => m_Wrapper.m_gameplay_Speak;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @CameraMovement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovement;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Pickup.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @SpeedUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @circle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @circle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @circle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @space.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @space.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @space.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Speak.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeak;
                @Speak.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeak;
                @Speak.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeak;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @SpeedUp.started += instance.OnSpeedUp;
                @SpeedUp.performed += instance.OnSpeedUp;
                @SpeedUp.canceled += instance.OnSpeedUp;
                @circle.started += instance.OnCircle;
                @circle.performed += instance.OnCircle;
                @circle.canceled += instance.OnCircle;
                @space.started += instance.OnSpace;
                @space.performed += instance.OnSpace;
                @space.canceled += instance.OnSpace;
                @Speak.started += instance.OnSpeak;
                @Speak.performed += instance.OnSpeak;
                @Speak.canceled += instance.OnSpeak;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnSpeedUp(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnSpeak(InputAction.CallbackContext context);
    }
}
