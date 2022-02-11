using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public class KeyboardInput : BaseInput {
        #region Variables
        protected bool cameraB;
        protected bool nextUnitB;
        protected bool commandMenuB;
        protected bool pauseMenuB;
        protected bool settingsMenuB;
        protected bool mainAttackB;
        protected bool altAttackB;
        #endregion
        
        
        
        #region Properties
        public bool CameraButton => cameraB;
        public bool NextUnitButton => nextUnitB;
        public bool CommandMenuButton => commandMenuB;
        public bool PauseMenuButton => pauseMenuB;
        public bool SettingsMenuButton => settingsMenuB;
        public bool MainAttackButton => mainAttackB;
        public bool AltAttackButton => altAttackB;
        #endregion


        #region Builtin Methods
        private void Start() {
            
        }
        #endregion
        
        
        
        #region Custom Methods
        protected override void HandleInputs() {
            base.HandleInputs();

            HandleCommandMenuButton();
            HandlePauseMenuButton();
            HandleSettingsMenuButton();
            ClampInput();
        }


        protected virtual void HandleCommandMenuButton() {
            commandMenuB = UnityEngine.Input.GetKeyDown(keys.commandMenu);
        }
        
        
        protected virtual void HandlePauseMenuButton() {
            pauseMenuB = UnityEngine.Input.GetKeyDown(keys.pauseMenu);
        }
        
        
        protected virtual void HandleSettingsMenuButton() {
            if (UnityEngine.Input.GetKeyDown(keys.settingsMenu)) Application.Quit();
        }


        protected virtual void ClampInput() {
            
        }
        #endregion
    }
}