using UnityEngine;
using TMW;

namespace TMW.Data
{
    [CreateAssetMenu(fileName = "Hexagon", menuName = "Scriptable Objects/Hexagon", order = 1)]
    public class HexagonInfo : ScriptableObject
    {
        [SerializeField] private HexagonType _type;
        [SerializeField] private Sprite _sprite;
        [SerializeField] private bool _isPassable = true;

        public HexagonType Type => _type;
        public Sprite Sprite => _sprite;
        public bool IsPassable => _isPassable;
    }
}