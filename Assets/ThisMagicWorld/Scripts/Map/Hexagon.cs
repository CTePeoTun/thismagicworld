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
            _type = dto.Info.Type;
            _isPassable = dto.Info.IsPassable;        
            _spriteRenderer.sprite = dto.Info.Sprite;
            _coordinate = dto.Coordinate;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Selected", this.gameObject);
        }

    }
}