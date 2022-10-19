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

        public void Create(int size)
        {
            if (size < 0)
                size = -size;
            for (int y = -size; y <= size; y++)
            {
                for (int x = -size; x <= size; x++)
                {
                    if (Mathf.Abs(x+y) <= size)
                        InitHexagon(x, y);
                }
            }
        }

        private void InitHexagon(int x, int y)
        {
            Hexagon hexagon = Instantiate(_hexagonPrefab) as Hexagon;
            Vector2Int coordinate = new Vector2Int(x, y);
            HexagonType type = GetRandomHexagonType();
            HexagonInfo info = ClientData.GetHexagonInfo(type);
            HexagonDto dto = new HexagonDto(coordinate, info);
            hexagon.Init(dto);
            hexagon.transform.localPosition = new Vector2(
                    ((float)x + (float)y/2) * _width,
                    (float)y * _heigth
                );
        }

        private HexagonType GetRandomHexagonType()
        {
            var random = new System.Random();
            return random.NextEnum<HexagonType>();
        }
    }
}