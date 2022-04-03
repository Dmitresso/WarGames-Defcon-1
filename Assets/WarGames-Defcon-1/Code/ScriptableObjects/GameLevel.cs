using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using WarGames_Defcon_1.Code.ScriptableObjects.Containers;
using WarGames_Defcon_1.Code.Scripts.Level;
using WarGames_Defcon_1.Code.Scripts.Unit;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    [CreateAssetMenu(fileName = "New Level Scene", menuName = "ScriptableObjects/GameLevel", order = 2)]
    public class GameLevel : ScriptableObject {
        public SceneAsset gameScene;
        public string description;
        public List<Vehicle> levelVehicles;
        public List<Objective> levelObjectives;
        public LevelStats levelStats;

        public LevelTexts textsENG;
        public LevelTexts textsRU;
    }
}