using System;
using System.Collections.Generic;
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

            HandleMainAttackButton();
            HandleAltAttackButton();
            HandleCameraButton();
            HandleNextUnitButton();
            HandleCommandMenuButton();
            HandlePauseMenuButton();
            HandleSettingsMenuButton();
            ClampInputs();
        }


        protected virtual void HandleMainAttackButton() => mainAttackB = UnityEngine.Input.GetKeyDown(keys.mainAttack);
        protected virtual void HandleAltAttackButton() => altAttackB = UnityEngine.Input.GetKeyDown(keys.altAttack);
        protected virtual void HandleCameraButton() => cameraB = UnityEngine.Input.GetKeyDown(keys.camera);
        protected virtual void HandleNextUnitButton() => nextUnitB = UnityEngine.Input.GetKeyDown(keys.nextUnit);
        protected virtual void HandleCommandMenuButton() => commandMenuB = UnityEngine.Input.GetKeyDown(keys.commandMenu);
        protected virtual void HandlePauseMenuButton() => pauseMenuB = UnityEngine.Input.GetKeyDown(keys.pauseMenu);
        protected virtual void HandleSettingsMenuButton() => settingsMenuB = UnityEngine.Input.GetKeyDown(keys.settingsMenu);
        
        
        protected virtual void ClampInputs() {
        }
        #endregion
    }
}