using System.Collections.Generic;
using UnityEngine;

namespace TMW
{
    public class GameView : MonoBehaviour
    {
        [SerializeField] private WorldGrid _worldGrid;

        public void CreateMap(List<HexagonDto> hexagonDtos)
        {
            _worldGrid.Create(hexagonDtos);
        }
    }
}