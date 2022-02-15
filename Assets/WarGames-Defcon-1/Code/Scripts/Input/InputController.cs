using UnityEngine;
using UnityEngine.Events;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    [RequireComponent(typeof(KeyboardInput))]
    public class InputController : InputSystem  {
        #region Variables
        [SerializeField] private KeyboardInput keyboardInput;
        [SerializeField] private InputType inputType = InputType.Keyboard;

        [Header("Input Events")]
        public UnityEvent onCameraButtonPressed = new();
        #endregion

        


        #region Builtin Methods
        private void Awake() {
            keyboardInput = GetComponent<KeyboardInput>();
            if (keyboardInput) SetInput(inputType);
        }

        
        private void Update() {
            ApplyInputs(
                keyboardInput.Horizontal,
                keyboardInput.Vertical,
                keyboardInput.CameraButton,
                keyboardInput.NextUnitButton, 
                keyboardInput.CommandMenuButton,
                keyboardInput.PauseMenuButton,
                keyboardInput.SettingsMenuButton,
                keyboardInput.MainAttackButton,
                keyboardInput.AltAttackButton
                );
        }
        #endregion

        

        #region Custom Methods
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