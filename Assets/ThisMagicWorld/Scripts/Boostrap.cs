using UnityEngine;
using UnityEngine.Tilemaps;
using TMW.Data;

namespace TMW
{
    public class Boostrap : MonoBehaviour
    {
        [SerializeField] private GameData _gameData;
        [SerializeField] private GameView _gameView;

        private GamePresenter _game;

        private void Awake()
        {
            InitData(); 
            InitGame();
        }

        private void Start()
        {
            _game.CreateMap();
        }

        private void InitData()
        {
            ClientData.Init(_gameData);
        }

        private void InitGame()
        {
            GameModel gameModel = new GameModel();
            _game = new GamePresenter(gameModel, _gameView);
        }
    }
}