using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public class KeyboardInput : BaseInput {
        #region Properties
        protected bool cameraB;
        public bool cameraButton => cameraB;
        
        protected bool pauseMenuB;
        public bool PauseMenuButton => pauseMenuB;
        #endregion


        #region Builtin Methods
        private void Start() {
            
        }
        #endregion
        
        
        
        #region Custom Methods
        protected override void HandleInputs() {
            base.HandleInputs();

            HandlePauseMenuButton();
            HandleSettingsMenuButton();
        }

        protected virtual void HandlePauseMenuButton() {
            pauseMenuB = UnityEngine.Input.GetKeyDown(keys.pauseMenu);
        }
        
        protected virtual void HandleSettingsMenuButton() {
            if (UnityEngine.Input.GetKeyDown(keys.settingsMenu)) Application.Quit();
        }
        #endregion
    }
}