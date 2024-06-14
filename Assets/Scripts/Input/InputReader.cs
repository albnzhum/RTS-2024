using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "RTS/Input Reader", fileName = "New Input Reader")]
public class InputReader : ScriptableObject, GameInputs.IGameplayActions, GameInputs.IUIActions
{
    public event UnityAction OnOpenPauseEvent = delegate { };
    public event UnityAction OnClosePauseEvent = delegate {  };

    private GameInputs _gameInputs;

    private void OnEnable()
    {
        if (_gameInputs == null)
        {
            _gameInputs = new GameInputs();

            _gameInputs.Gameplay.SetCallbacks(this);
            _gameInputs.UI.SetCallbacks(this);
        }
    }

    public void EnableGameplayInput()
    {
        _gameInputs.UI.Disable();
        _gameInputs.Gameplay.Enable();
    }

    public void EnableUIInput()
    {
        _gameInputs.Gameplay.Disable();
        _gameInputs.UI.Enable();
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnOpenPauseEvent.Invoke();
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
        
    }
}
