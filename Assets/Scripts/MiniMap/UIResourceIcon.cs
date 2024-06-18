using UnityEngine;
using UnityEngine.UI;

public class UIResourceIcon : MonoBehaviour
{
    [SerializeField] private GameObject resourceIcon;

    public Image ResourceIcon => resourceIcon.GetComponent<Image>();
}
