using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMW
{
    public class GameModel
    {
        public Action<List<HexagonDto>> OnMapReady;

        private List<HexagonDto> _hexagons = new List<HexagonDto>();

        public void CreateMap(int size)
        {
            if (size < 0)
                size = -size;
            for (int y = -size; y <= size; y++)
            {
                for (int x = -size; x <= size; x++)
                {
                    if (Mathf.Abs(x + y) <= size)
                    {

                        HexagonDto hexagon = CreateHexagon(x, y);
                        _hexagons.Add(hexagon);
                    }
                }
            }
            OnMapReady?.Invoke(_hexagons);
        }

        private HexagonDto CreateHexagon(int x, int y)
        {
            Vector2Int coordinate = new Vector2Int(x, y);
            HexagonType type = GetRandomHexagonType();///
            HexagonDto dto = new HexagonDto(type, coordinate);
            return dto;
        }

        private HexagonType GetRandomHexagonType()
        {
            var random = new System.Random();
            return random.NextEnum<HexagonType>();
        }
    }
}