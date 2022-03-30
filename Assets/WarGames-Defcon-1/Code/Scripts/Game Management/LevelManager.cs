using UnityEngine;
using WarGames_Defcon_1.Code.ScriptableObjects;
using WarGames_Defcon_1.Code.Scripts.Controller;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    public class LevelManager : MonoBehaviour {
        #region Fields
        [SerializeField] private GameLevel levelSO;

        private PlayerController playerController;
        #endregion



        #region Properties
        #endregion


        
        #region Builtin Methods
        private void Awake() {
            playerController = FindObjectOfType<PlayerController>();
        }


        private void OnEnable() {
            playerController.Vehicles = levelSO.levelUnits;
        }
        #endregion
    }
}