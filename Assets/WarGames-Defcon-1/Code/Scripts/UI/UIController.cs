using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.UI.Menu;


namespace WarGames_Defcon_1.Code.Scripts.UI {
    [DefaultExecutionOrder(-50)]
    public class UIController : Singleton<UIController> {
        #region Fields
        [SerializeField] private bool pausable = true;
        [SerializeField] private bool gamePaused;
        
        [SerializeField] private MainMenu mainMenu;
        [SerializeField] private OptionsMenu optionsMenu;
        [SerializeField] private CommandMenu commandMenu;
        [SerializeField] private CommandCenterMenu commandCenterMenu;
        [SerializeField] private SettingsMenu settingsMenu;
        [SerializeField] private ExitMenu exitMenu;
        [SerializeField] private FadingLoadingScreen loadingScreen;
        #endregion



        #region BUILTIN METHODS
        private void Awake() {
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