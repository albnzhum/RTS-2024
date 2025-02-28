//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/GameInputs.inputactions
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

public partial class @GameInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""5ee50769-9415-4e34-83c4-ef9480e6a79b"",
            ""actions"": [
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a8e85599-410c-445c-b449-c428149a6341"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0a09b6c3-c51e-4e0d-9a2a-25c962419a7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom Camera"",
                    ""type"": ""Value"",
                    ""id"": ""4f1e6117-782e-4f95-ad5b-07cea920fd88"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""4a221972-e4f9-4375-80aa-47eefe8e88b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6300ac14-7ecc-451c-8a3d-da551cd8a752"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7032b348-484a-42cc-8442-6de58e615f1f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e1fcabff-0d34-45d4-814f-d64b306c50d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8cef53e4-2daf-4275-aae0-a114b2abb204"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""06894730-479d-44fd-9267-af9b8cfc12b1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb03e979-aea3-4ee3-b653-3ff74482e43d"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""600a3a64-4cb1-42d9-902c-cf3351780025"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""86ba5d43-1164-43e8-b0f3-9da1e4bf1312"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Close Pause"",
                    ""type"": ""Button"",
                    ""id"": ""2b863d9d-0ea6-4b81-b91b-a16b63f3c83b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea0cd3bd-4c3d-4c0c-93b3-10bb741eab97"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1944575-b02b-44bb-9ee0-569336a2c48b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Selection"",
            ""id"": ""8b144f93-6d53-4889-9e10-67645d608bf1"",
            ""actions"": [
                {
                    ""name"": ""Selection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""45f3b020-da82-45f0-89ff-e109e067e61b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectionBoxMouseDown"",
                    ""type"": ""Button"",
                    ""id"": ""68859bff-75f9-4545-95ea-3b7196f4de20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectionBoxMouseUp"",
                    ""type"": ""Button"",
                    ""id"": ""8a8df128-ee7e-452c-944c-6c79adf7af20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bb9f61b9-0a0f-4714-99f6-37146c153af0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a026b9d7-7170-4bc1-a1c5-05c3206e4ee4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionBoxMouseDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""156dd4d2-8b7e-4b86-9444-474f25fc2bf8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionBoxMouseUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_CameraMovement = m_Gameplay.FindAction("Camera Movement", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_ZoomCamera = m_Gameplay.FindAction("Zoom Camera", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ClosePause = m_UI.FindAction("Close Pause", throwIfNotFound: true);
        // Selection
        m_Selection = asset.FindActionMap("Selection", throwIfNotFound: true);
        m_Selection_Selection = m_Selection.FindAction("Selection", throwIfNotFound: true);
        m_Selection_SelectionBoxMouseDown = m_Selection.FindAction("SelectionBoxMouseDown", throwIfNotFound: true);
        m_Selection_SelectionBoxMouseUp = m_Selection.FindAction("SelectionBoxMouseUp", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_CameraMovement;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_ZoomCamera;
    public struct GameplayActions
    {
        private @GameInputs m_Wrapper;
        public GameplayActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraMovement => m_Wrapper.m_Gameplay_CameraMovement;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @ZoomCamera => m_Wrapper.m_Gameplay_ZoomCamera;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @CameraMovement.started += instance.OnCameraMovement;
            @CameraMovement.performed += instance.OnCameraMovement;
            @CameraMovement.canceled += instance.OnCameraMovement;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @ZoomCamera.started += instance.OnZoomCamera;
            @ZoomCamera.performed += instance.OnZoomCamera;
            @ZoomCamera.canceled += instance.OnZoomCamera;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @CameraMovement.started -= instance.OnCameraMovement;
            @CameraMovement.performed -= instance.OnCameraMovement;
            @CameraMovement.canceled -= instance.OnCameraMovement;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @ZoomCamera.started -= instance.OnZoomCamera;
            @ZoomCamera.performed -= instance.OnZoomCamera;
            @ZoomCamera.canceled -= instance.OnZoomCamera;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ClosePause;
    public struct UIActions
    {
        private @GameInputs m_Wrapper;
        public UIActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ClosePause => m_Wrapper.m_UI_ClosePause;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
            @ClosePause.started += instance.OnClosePause;
            @ClosePause.performed += instance.OnClosePause;
            @ClosePause.canceled += instance.OnClosePause;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
            @ClosePause.started -= instance.OnClosePause;
            @ClosePause.performed -= instance.OnClosePause;
            @ClosePause.canceled -= instance.OnClosePause;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);

    // Selection
    private readonly InputActionMap m_Selection;
    private List<ISelectionActions> m_SelectionActionsCallbackInterfaces = new List<ISelectionActions>();
    private readonly InputAction m_Selection_Selection;
    private readonly InputAction m_Selection_SelectionBoxMouseDown;
    private readonly InputAction m_Selection_SelectionBoxMouseUp;
    public struct SelectionActions
    {
        private @GameInputs m_Wrapper;
        public SelectionActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Selection => m_Wrapper.m_Selection_Selection;
        public InputAction @SelectionBoxMouseDown => m_Wrapper.m_Selection_SelectionBoxMouseDown;
        public InputAction @SelectionBoxMouseUp => m_Wrapper.m_Selection_SelectionBoxMouseUp;
        public InputActionMap Get() { return m_Wrapper.m_Selection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectionActions set) { return set.Get(); }
        public void AddCallbacks(ISelectionActions instance)
        {
            if (instance == null || m_Wrapper.m_SelectionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SelectionActionsCallbackInterfaces.Add(instance);
            @Selection.started += instance.OnSelection;
            @Selection.performed += instance.OnSelection;
            @Selection.canceled += instance.OnSelection;
            @SelectionBoxMouseDown.started += instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseDown.performed += instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseDown.canceled += instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseUp.started += instance.OnSelectionBoxMouseUp;
            @SelectionBoxMouseUp.performed += instance.OnSelectionBoxMouseUp;
            @SelectionBoxMouseUp.canceled += instance.OnSelectionBoxMouseUp;
        }

        private void UnregisterCallbacks(ISelectionActions instance)
        {
            @Selection.started -= instance.OnSelection;
            @Selection.performed -= instance.OnSelection;
            @Selection.canceled -= instance.OnSelection;
            @SelectionBoxMouseDown.started -= instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseDown.performed -= instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseDown.canceled -= instance.OnSelectionBoxMouseDown;
            @SelectionBoxMouseUp.started -= instance.OnSelectionBoxMouseUp;
            @SelectionBoxMouseUp.performed -= instance.OnSelectionBoxMouseUp;
            @SelectionBoxMouseUp.canceled -= instance.OnSelectionBoxMouseUp;
        }

        public void RemoveCallbacks(ISelectionActions instance)
        {
            if (m_Wrapper.m_SelectionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISelectionActions instance)
        {
            foreach (var item in m_Wrapper.m_SelectionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SelectionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SelectionActions @Selection => new SelectionActions(this);
    public interface IGameplayActions
    {
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnClosePause(InputAction.CallbackContext context);
    }
    public interface ISelectionActions
    {
        void OnSelection(InputAction.CallbackContext context);
        void OnSelectionBoxMouseDown(InputAction.CallbackContext context);
        void OnSelectionBoxMouseUp(InputAction.CallbackContext context);
    }
}
