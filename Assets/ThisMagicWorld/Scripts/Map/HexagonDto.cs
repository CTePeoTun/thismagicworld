using UnityEngine;
using TMW.Data;

namespace TMW
{
    public class HexagonDto
    {
        public Vector2Int Coordinate { get;  set; }
        public HexagonInfo Info { get; set; }

        public HexagonDto(Vector2Int coordinate, HexagonInfo info)
        {
            Coordinate = coordinate;
            Info = info;
        }
    }
}