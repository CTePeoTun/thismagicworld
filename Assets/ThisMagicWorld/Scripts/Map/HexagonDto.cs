using UnityEngine;
using TMW.Data;

namespace TMW
{
    public class HexagonDto
    {
        public HexagonType Type { get; set; }
        public Vector2Int Coordinate { get;  set; }

        public HexagonDto(HexagonType type, Vector2Int coordinate)
        {
            Type = type;
            Coordinate = coordinate;            
        }
    }
}