using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Service;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    public class GameManager : Singleton<GameManager> {
        #region Fields
        [SerializeField] private bool pausable = true;
        [SerializeField] private bool gamePaused = true;
        [SerializeField] private GameObject[] systemPrefabs;
        private List<GameObject> instancedSystemPrefabs;
        #endregion



        #region Builtin Methods
        private void Awake() {
            InstantiateSystemPrefabs();
        }
        #endregion
        
        
        
        #region Custom Methods
        private void InstantiateSystemPrefabs() {
            foreach (var go in systemPrefabs) {
                var prefabInstance = Instantiate(go);
                instancedSystemPrefabs.Add(prefabInstance);
            }
        }


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
        
        
        private void ExitApp() {
            #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
            #endif
            Application.Quit();
        }
        #endregion
    }
}