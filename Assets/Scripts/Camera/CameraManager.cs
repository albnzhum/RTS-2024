using UnityEngine;

/// <summary>
/// Устанавливает вид камеры на базу игрока
/// </summary>
public class CameraManager : MonoBehaviour
{
    [SerializeField] private float offset = 10f;
    
    private GameObject[] factionSlots;

    private Vector3 initialCamLookPosition;

    private void Start()
    {
        factionSlots = GameObject.FindGameObjectsWithTag("Town Center");

        foreach (var slot in factionSlots)
        {
            if (slot.GetComponent<FactionSlot>().CurrentPlayer.IsMainPlayer)
            {
                initialCamLookPosition = slot.transform.position;
                break;
            }
        }
        
        SetPosition(initialCamLookPosition);
    }
    
    private void SetPosition(Vector3 targetPosition)
    {
        Vector3 newPosition = new Vector3(targetPosition.x, targetPosition.y + 15, targetPosition.z - offset);
        transform.position = newPosition;
    }
}