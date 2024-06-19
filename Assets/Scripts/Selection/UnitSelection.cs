using System.Collections.Generic;
using RTS.Units;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private RectTransform selectionBox;

    private List<UnitEntity> units = new List<UnitEntity>();
    public List<UnitEntity> Units => units;

    private Vector2 startPosition;
    private Vector2 endPosition;

    void Start()
    {
        selectionBox.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
            selectionBox.gameObject.SetActive(true);
            units.Clear();
        }
        
        if (Input.GetMouseButton(0))
        {
            endPosition = Input.mousePosition;
            UpdateSelectionBox();
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            selectionBox.gameObject.SetActive(false);
            SelectObjects();
        }
    }

    void UpdateSelectionBox()
    {
        float width = endPosition.x - startPosition.x;
        float height = endPosition.y - startPosition.y;

        selectionBox.sizeDelta = new Vector2(Mathf.Abs(width), Mathf.Abs(height));
        selectionBox.anchoredPosition = startPosition + new Vector2(width / 2, height / 2);
    }

    void SelectObjects()
    {
        Vector2 min = selectionBox.anchoredPosition - (selectionBox.sizeDelta / 2);
        Vector2 max = selectionBox.anchoredPosition + (selectionBox.sizeDelta / 2);

        foreach (GameObject selectable in GameObject.FindGameObjectsWithTag("Unit"))
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(selectable.transform.position);
            if (screenPos.x > min.x && screenPos.x < max.x && screenPos.y > min.y && screenPos.y < max.y)
            {
                var unit = selectable.GetComponent<UnitEntity>();
                units.Add(unit);
                Debug.Log("Selected: " + selectable.name);
            }
        }
    }
}
