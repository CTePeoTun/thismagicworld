using UnityEngine;
using UnityEngine.Tilemaps;
using TMW.Data;

namespace TMW
{
    public class Boostrap : MonoBehaviour
    {
        [SerializeField] private GameData _gameData;
        [SerializeField] private WorldGrid _worldGrid;

        private void Awake()
        {
            InitData();
            _worldGrid.Create(3);
        }

        private void InitData()
        {
            ClientData.Init(_gameData);
        }
    }
}