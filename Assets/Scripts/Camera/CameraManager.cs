using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private Transform _townCenter;

    private void Start()
    {
        _townCenter = GameObject.FindWithTag("Town Center").transform;
        
        //transform.LookAt(_townCenter);
    }
}