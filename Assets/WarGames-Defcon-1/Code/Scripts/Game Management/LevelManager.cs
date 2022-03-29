using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.ScriptableObjects;
using WarGames_Defcon_1.Code.Scripts.Controller;
using WarGames_Defcon_1.Code.Scripts.Unit;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    public class LevelManager : MonoBehaviour {
        #region Fields
        [SerializeField] private GameLevel levelSO;

        private List<Vehicle> levelVehicles;
        private PlayerController playerController;
        #endregion



        #region Properties
        public IEnumerable<Vehicle> LevelVehicles => levelVehicles;
        #endregion


        
        #region Builtin Methods
        private void Awake() {
            playerController = FindObjectOfType<PlayerController>();
            levelVehicles = levelSO.levelUnits;
        }


        private void Start() {
            
        }
        #endregion
    }
}