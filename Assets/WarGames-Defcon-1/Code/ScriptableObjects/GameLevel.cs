using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.ScriptableObjects.Containers;
using WarGames_Defcon_1.Code.Scripts.Unit;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    [CreateAssetMenu(fileName = "New Level Scene", menuName = "ScriptableObjects/GameLevel", order = 2)]
    public class GameLevel : GameScene {
        public List<Vehicle> levelUnits;

        [Header("ENG text files")] public LevelTexts textsENG;
        [Header("RU text files")] public LevelTexts textsRU;
    }
}