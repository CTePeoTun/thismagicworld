using System.Collections;
using System.Collections.Generic;
using TMW.Data;
using UnityEngine;

namespace TMW
{
    public class WorldGrid : MonoBehaviour
    {
        [SerializeField] private Hexagon _hexagonPrefab;
        [SerializeField] private float _width = 1;
        [SerializeField] private float _heigth = 1;

        private List<Hexagon> _hexagons = new List<Hexagon>();

        public void Create(List<HexagonDto> dtos)
        {
            foreach (var dto in dtos)
            {
                Hexagon hexagon = CreateHexagon(dto);
                _hexagons.Add(hexagon);
            }
        }

        private Hexagon CreateHexagon(HexagonDto dto)
        {
            Hexagon hexagon = Instantiate(_hexagonPrefab) as Hexagon;
            hexagon.Init(dto);
            hexagon.transform.SetParent(this.transform);
            hexagon.transform.localPosition = GetHexagonPosition(dto.Coordinate);
            return hexagon;
        }

        private Vector2 GetHexagonPosition(Vector2Int coordinate)
        {
            Vector2 result = coordinate;
            result.x = (result.x + result.y / 2) *_width;
            result.y = result.y * _heigth;
            return result;
        }

        
    }
}