using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "RTS/Input Reader", fileName = "New Input Reader")]
public class InputReader : ScriptableObject, GameInputs.IGameplayActions, GameInputs.IUIActions, GameInputs.ISelectionActions
{
    public event UnityAction<Vector2> CameraZoomEvent = delegate { };
    public event UnityAction<Vector2> CameraMovementEvent = delegate { };
    public event UnityAction<Vector2> SelectionBoxEvent = delegate {  };
    public event UnityAction SelectionBoxMouseDown = delegate { };
    public event UnityAction SelectionBoxMouseUp = delegate { };
    public event UnityAction OnOpenPauseEvent = delegate { };
    public event UnityAction OnClosePauseEvent = delegate { };

    private bool isGameplayInputEnabled = false;
    public bool IsGameplayInputEnabled => isGameplayInputEnabled;

    private GameInputs _gameInputs;

    private void OnEnable()
    {
        if (_gameInputs == null)
        {
            _gameInputs = new GameInputs();

            _gameInputs.Gameplay.SetCallbacks(this);
            _gameInputs.UI.SetCallbacks(this);
            _gameInputs.Selection.SetCallbacks(this);
        }
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    private void DisableAllInput()
    {
        _gameInputs.Gameplay.Disable();
        _gameInputs.UI.Disable();
    }

    public void EnableGameplayInput()
    {
        isGameplayInputEnabled = true;

        _gameInputs.UI.Disable();
        _gameInputs.Gameplay.Enable();
    }

    public void EnableUIInput()
    {
        isGameplayInputEnabled = false;

        _gameInputs.Gameplay.Disable();
        _gameInputs.UI.Enable();
    }

    public void OnZoomCamera(InputAction.CallbackContext context)
    {
        CameraZoomEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnOpenPauseEvent.Invoke();
        }
    }

    public void OnSelection(InputAction.CallbackContext context)
    {
        SelectionBoxEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnSelectionBoxMouseDown(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            SelectionBoxMouseDown.Invoke();
        }
    }

    public void OnSelectionBoxMouseUp(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            SelectionBoxMouseUp.Invoke();
        }
    }

    public void OnClosePause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnClosePauseEvent.Invoke();
        }
    }

    public void OnClick(InputAction.CallbackContext context)
    {
    }

    public void OnCameraMovement(InputAction.CallbackContext context)
    {
        CameraMovementEvent.Invoke(context.ReadValue<Vector2>());
    }
}