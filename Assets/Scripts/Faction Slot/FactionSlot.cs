using RTS.UI;
using UnityEngine;

public class FactionSlot : MonoBehaviour
{
    [SerializeField] private Transform initialCameraPosition;
    [SerializeField] private GameSettingsSO gameSettings;
    
    public Player CurrentPlayer { get; set; }

}
