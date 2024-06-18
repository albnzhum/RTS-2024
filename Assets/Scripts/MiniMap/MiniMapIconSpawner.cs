using System.Collections.Generic;
using RTS.UI;
using UnityEngine;
using UnityEngine.UI;

namespace RTS.Resources.MiniMap
{
    public class MiniMapIconSpawner : MonoBehaviour
    {
        [Header("UI")] 
        [SerializeField] private RectTransform miniMapRectTransform;
        [SerializeField] private Camera minimapCamera;
        [SerializeField] private GameObject townCenterImage;

        [Header("Core")] 
        [SerializeField] private GameSettingsSO gameSettings;

        private List<UIResourceIcon> _resources = new List<UIResourceIcon>();
        private List<FactionSlot> _playersBase = new List<FactionSlot>();

        void Start()
        {
            var resources = GameObject.FindGameObjectsWithTag("Resource");
            foreach (var resource in resources)
            {
                var resourceIcon = resource.GetComponent<UIResourceIcon>();
                if (resourceIcon != null)
                {
                    _resources.Add(resourceIcon);
                }
            }

            var playersBase = GameObject.FindGameObjectsWithTag("Town Center");
            foreach (var playerBase in playersBase)
            {
                var factionSlot = playerBase.GetComponent<FactionSlot>();
                if (factionSlot != null)
                {
                    _playersBase.Add(factionSlot);
                }
            }

            CreateResourceIcons();
            CreatePlayersBaseIcon();
        }
        
        private void CreateResourceIcons()
        {
            foreach (UIResourceIcon resource in _resources)
            {
                var icon = GameObject.Instantiate(resource.ResourceIcon, miniMapRectTransform);
                UpdateIconPosition(icon.rectTransform, resource.transform.position);
            }
        }

        private void CreatePlayersBaseIcon()
        {
            foreach (FactionSlot factionSlot in _playersBase)
            {
                var icon = GameObject.Instantiate(townCenterImage, miniMapRectTransform);
                var image = icon.GetComponent<Image>();
                image.color = factionSlot.CurrentPlayer.Color;
                UpdateIconPosition(image.rectTransform, factionSlot.transform.position);
            }
        }

        private void UpdateIconPosition(RectTransform icon, Vector3 worldPosition)
        {
            if (WorldPointToLocalPointInMinimapCanvas(worldPosition, out Vector3 localPosition))
            {
                icon.localPosition = localPosition;
            }
        }
        
        public bool WorldPointToLocalPointInMinimapCanvas(Vector3 worldPoint, out Vector3 localPoint, float height = 0.0f)
        {
            Vector2 viewportPoint = minimapCamera.WorldToViewportPoint(worldPoint);
            Vector2 miniMapSize = miniMapRectTransform.rect.size;
            
            Vector2 localPoint2D = new Vector2(
                (viewportPoint.x - 0.5f) * miniMapSize.x,
                (viewportPoint.y - 0.5f) * miniMapSize.y
            );

            localPoint = new Vector3(localPoint2D.x, localPoint2D.y, height);
            return true;
        }
    }
}
