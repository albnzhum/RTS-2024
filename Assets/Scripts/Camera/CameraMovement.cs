using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;

    [Header("Horizontal Translation")] 
    [SerializeField] private float maxSpeed = 15f;

    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float damping = 15f;

    [Header("Vertical Translation")] 
    [SerializeField] private float stepSize = 2f;

    [SerializeField] private float zoomDampening = 7.5f;
    [SerializeField] private float minHeight = 5f;
    [SerializeField] private float maxHeight = 50f;
    [SerializeField] private float zoomSpeed = 2f;

    private Transform _cameraTransform;
    private float _speed;
    private Vector3 _targetPosition;
    private float _zoomHeight;
    private Vector3 _horizontalVelocity;
    private Vector3 _lastPosition;

    private Vector3 _startDrag;

    private Vector3 _cameraMovementInput;

    private void Awake()
    {
        _cameraTransform = GetComponentInChildren<Camera>().transform;
    }

    private void OnEnable()
    {
        _zoomHeight = _cameraTransform.localPosition.y;

        _lastPosition = transform.position;
        
        inputReader.CameraZoomEvent += ZoomCamera;
        inputReader.CameraMovementEvent += MoveCamera;
    }

    private void OnDisable()
    {
        inputReader.CameraZoomEvent -= ZoomCamera;
        inputReader.CameraMovementEvent -= MoveCamera;
    }

    private void Update()
    {
        if (inputReader.IsGameplayInputEnabled)
        {
            UpdateVelocity();
            UpdateBasePosition();
            UpdateCameraPosition();
        }
    }
    
    private void MoveCamera(Vector2 movement)
    {
        _cameraMovementInput = movement;
    }

    private void ZoomCamera(Vector2 position)
    {
        float inputValue = -position.y / 100f;

        if (Mathf.Abs(inputValue) > 0.1f)
        {
            _zoomHeight = _cameraTransform.localPosition.y + inputValue * stepSize;

            if (_zoomHeight < minHeight) _zoomHeight = minHeight;
            else if (_zoomHeight > maxHeight) _zoomHeight = maxHeight;
        }
    }

    private void UpdateVelocity()
    {
        _horizontalVelocity = (transform.position - _lastPosition) / Time.deltaTime;
        _horizontalVelocity.y = 0f;
        _lastPosition = transform.position;
    }

    private void UpdateBasePosition()
    {
        Vector3 moveDirection = new Vector3(_cameraMovementInput.x, 0, _cameraMovementInput.y);

        if (moveDirection.sqrMagnitude > 0.1f)
        {
            _targetPosition += moveDirection.normalized;
        }

        if (_targetPosition.sqrMagnitude > 0.1f)
        {
            _speed = Mathf.Lerp(_speed, maxSpeed, Time.deltaTime * acceleration);
            transform.position += _targetPosition * _speed * Time.deltaTime;
        }
        else
        {
            _horizontalVelocity = Vector3.Lerp(_horizontalVelocity, Vector3.zero, Time.deltaTime * damping);
            transform.position += _horizontalVelocity * Time.deltaTime;
        }

        _targetPosition = Vector3.zero;
    }

    private void UpdateCameraPosition()
    {
        Vector3 zoomTarget = new Vector3(_cameraTransform.localPosition.x,
            _zoomHeight, _cameraTransform.localPosition.z);

        zoomTarget -= zoomSpeed * (_zoomHeight - _cameraTransform.localPosition.y) * Vector3.forward;

        _cameraTransform.localPosition = Vector3.Lerp(_cameraTransform.localPosition,
            zoomTarget, Time.deltaTime * zoomDampening);
    }
}
