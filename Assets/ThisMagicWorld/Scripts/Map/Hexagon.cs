using TMW.Data;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMW
{
    public class Hexagon : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private HexagonType _type;
        private bool _isPassable;
        private Vector2Int _coordinate;
        

        public HexagonType Type => _type;
        public bool IsPassable => _isPassable;
        public Vector2Int Coordinate => _coordinate;

        public void Init(HexagonDto dto)
        {
            _type = dto.Type;
            HexagonInfo info = ClientData.GetHexagonInfo(_type);       
            _spriteRenderer.sprite = info.Sprite;
            _coordinate = dto.Coordinate;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Selected", this.gameObject);
        }

    }
}