using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, GameInputs.IGameplayActions, GameInputs.IUIActions
{
    public void OnPause(InputAction.CallbackContext context)
    {
        
    }
    
    public void OnClick(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnCameraMovement(InputAction.CallbackContext context)
    {
        
    }
}
