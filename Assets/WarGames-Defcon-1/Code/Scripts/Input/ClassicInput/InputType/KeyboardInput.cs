using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input.Keys;

namespace WarGames_Defcon_1.Code.Scripts.Input.ClassicInput.InputType {
    public class KeyboardInput : BaseInput {
        #region Variables
        [SerializeField] protected KeyboardKeys keyboardKeys;
        
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
        private void Awake() {
            keyboardKeys = new KeyboardKeys(
                "Horizontal",
                "Vertical",
                KeyCode.Q,
                KeyCode.E,
                KeyCode.C,
                KeyCode.V,
                KeyCode.F,
                KeyCode.Mouse0,
                KeyCode.Mouse1
            );
        }
        
        
        private void Start() {
        }
        #endregion
        
        
        
        #region Custom Methods
        public void ProvideInputs() {
             Debug.Log("KEYBOARD");
        }
        
        
        public void HandleInputs() {
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


        protected virtual void HandleMainAttackButton() => mainAttackB = UnityEngine.Input.GetKeyDown(keyboardKeys.mainAttack);
        protected virtual void HandleAltAttackButton() => altAttackB = UnityEngine.Input.GetKeyDown(keyboardKeys.altAttack);
        protected virtual void HandleCameraButton() => cameraB = UnityEngine.Input.GetKeyDown(keyboardKeys.camera);
        protected virtual void HandleNextUnitButton() => nextUnitB = UnityEngine.Input.GetKeyDown(keyboardKeys.nextUnit);
        protected virtual void HandleCommandMenuButton() => commandMenuB = UnityEngine.Input.GetKeyDown(keyboardKeys.commandMenu);
        protected virtual void HandlePauseMenuButton() => pauseMenuB = UnityEngine.Input.GetKeyDown(keyboardKeys.pauseMenu);
        protected virtual void HandleSettingsMenuButton() => settingsMenuB = UnityEngine.Input.GetKeyDown(keyboardKeys.settingsMenu);
        
        
        protected virtual void ClampInputs() {
        }
        #endregion
    }
}