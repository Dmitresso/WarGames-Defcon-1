using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Controller;
using WarGames_Defcon_1.Code.Scripts.Unit;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    public class LevelManager : MonoBehaviour {
        #region Fields
        [SerializeField] private bool pausable = true;
        [SerializeField] private bool gamePaused;
        [SerializeField] private List<Vehicle> levelVehicles;
        
        private PlayerController playerController;
        #endregion



        #region Properties
        public IEnumerable<Vehicle> LevelVehicles => levelVehicles;
        #endregion


        
        #region Builtin Methods
        private void Awake() {
            playerController = FindObjectOfType<PlayerController>();
        }


        private void Start() {
            
        }
        #endregion



        #region Custom Methods
        private void PauseGame() {
            gamePaused = true;
            Time.timeScale = 0;
            // audioManager.SetVolume(0.3f);
            // pauseMenu.gameObject.SetActive(true);
            // cursorController.UnlockCursor();
            // cursorController.MakeCursorVisible();
            // CursorChanged?.Invoke(Cursors.System);
        }
    
        
        private void ResumeGame() {
            gamePaused = false;
            Time.timeScale = 1;
            // audioManager.SetVolume(0.8f);
            // pauseMenu.gameObject.SetActive(false);
            // cursorController.LockCursor();
            // cursorController.MakeCursorInvisible();
            // CursorChanged?.Invoke(Cursors.Dot);
        }
    
        
        public void PressPause() {
            if (!pausable) return;
            if (gamePaused) ResumeGame();
            else PauseGame();
        }
        #endregion
    }
}