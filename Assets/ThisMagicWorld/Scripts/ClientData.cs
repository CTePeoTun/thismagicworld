using System;
using UnityEngine;
using TMW.Data;

namespace TMW
{
    public static class ClientData
    {
        private static GameData _gameData;
        public static bool IsInitialized {get; private set;}


        public static void Init(GameData gameData)
        {
            _gameData = gameData;
            IsInitialized = true;
            Debug.Log("Client Data has been initialized!");
        }

        public static HexagonInfo GetHexagonInfo(HexagonType type)
        {
            CheckInitialize();
            return _gameData.GetHexagonInfo(type);
        }

        private static void CheckInitialize()
        {
            if (IsInitialized == false)
            {
                throw new Exception("Client Data NOT initialized!");
            }                
        }
    }
}