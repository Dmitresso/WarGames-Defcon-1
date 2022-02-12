using UnityEngine;
using UnityEngine.Events;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public enum InputType {
        Keyboard,
        Xbox,
        Mobile
    }
    
    
    [RequireComponent(typeof(KeyboardInput))]
    public class InputController : MonoBehaviour {
        #region Variables
        [SerializeField] private KeyboardInput keyboardInput;
        [SerializeField] private InputType inputType = InputType.Keyboard;
        
        private float horizontal;
        private float vertical;
        
        private bool cameraButton;
        private bool nextUnitButton;
        private bool commandMenuButton;
        private bool pauseMenuButton;
        private bool settingsMenuButton;
        private bool mainAttackButton;
        private bool altAttackButton;


        [Header("Input Events")]
        public UnityEvent onCameraButtonPressed = new();
        #endregion


        #region Properties
        public float Horizontal => horizontal;
        public float Vertical => vertical;
        
        public bool CameraButton => cameraButton;
        public bool NextUnitButton => nextUnitButton;
        public bool CommandMenuButton => commandMenuButton;
        public bool PauseMenuButton => pauseMenuButton;
        public bool SettingsMenuButton => settingsMenuButton;
        public bool MainAttackButton => mainAttackButton;
        public bool AltAttackButton => altAttackButton;
        #endregion
        


        #region Builtin Methods
        private void Start() {
            keyboardInput = GetComponent<KeyboardInput>();
            if (keyboardInput) SetInput(inputType);
        }

        
        private void Update() {
            ApplyInputs();
        }
        #endregion

        

        #region Custom Methods
        private void ApplyInputs() {
            horizontal = keyboardInput.Horizontal;
            vertical = keyboardInput.Vertical;
            cameraButton = keyboardInput.CameraButton;
            nextUnitButton = keyboardInput.NextUnitButton;
            commandMenuButton = keyboardInput.CommandMenuButton;
            pauseMenuButton = keyboardInput.PauseMenuButton;
            settingsMenuButton = keyboardInput.SettingsMenuButton;
            mainAttackButton = keyboardInput.MainAttackButton;
            altAttackButton = keyboardInput.AltAttackButton;
        }
        
        
        private void SetInput(InputType type) {
            inputType = type;
            switch (type) {
                case InputType.Keyboard:
                    keyboardInput.enabled = true;
                    break;
                case InputType.Xbox:
                    keyboardInput.enabled = false;
                    break;
                case InputType.Mobile:
                    keyboardInput.enabled = false;
                    break;
            }
        }
        #endregion
    }
}