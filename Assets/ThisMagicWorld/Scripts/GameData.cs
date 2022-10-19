using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMW;
using System;

namespace TMW.Data
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Scriptable Objects/GameData", order = 1)]
    public class GameData : ScriptableObject
    {
        [SerializeField] private List<HexagonInfo> _hexagons;

        public HexagonInfo GetHexagonInfo(HexagonType type)
        {
            HexagonInfo info = _hexagons.FirstOrDefault(x => x.Type == type);
            Debug.Assert(info != null, string.Format("Type {0} does not have description on {1}", type, this.GetType().Name), this);
            return info;
        }
    }
}