using UnityEngine;
using UnityEngine.Events;
using WarGames_Defcon_1.Code.Scripts.Input.ClassicInput.InputType;
using WarGames_Defcon_1.Code.Scripts.Input.InputType;


namespace WarGames_Defcon_1.Code.Scripts.Input.ClassicInput {
    [RequireComponent(typeof(KeyboardInput),
                     typeof(XboxInput),
                     typeof(MobileInput))]
    public class InputController : InputReceiver  {
        #region Variables
        //[SerializeField] private KeyboardInput keyboardInput;
        [SerializeField] private IInputSystem input;


        [Header("Input Events")]
        public UnityEvent onCameraButtonPressed = new();
        #endregion

        
        
        protected override Scripts.Input.InputType.InputType SelectedInputType {
            get => selectedInputType;
            set {
                inspectorInputType = selectedInputType = value;
                SetInput(selectedInputType);
            }
        }


        #region Builtin Methods
        protected void Awake() {
            //keyboardInput = GetComponent<KeyboardInput>();
            //if (keyboardInput) SetInput();
        }


        private void Update() {
            // ApplyInputs(
            //     keyboardInput.Horizontal,
            //     keyboardInput.Vertical,
            //     keyboardInput.CameraButton,
            //     keyboardInput.NextUnitButton,
            //     keyboardInput.CommandMenuButton,
            //     keyboardInput.PauseMenuButton,
            //     keyboardInput.SettingsMenuButton,
            //     keyboardInput.MainAttackButton,
            //     keyboardInput.AltAttackButton
            // );
        }
        #endregion

        

        #region Custom Methods
        protected override void SetInput(Scripts.Input.InputType.InputType type) {
            switch (type) {
                case Scripts.Input.InputType.InputType.Keyboard :
                    input = GetComponent<KeyboardInput>();
                    //GetComponent<XboxInput>().enabled = false;
                    break;
                case Scripts.Input.InputType.InputType.Xbox:
                    input = GetComponent<XboxInput>();
                    break;
                case Scripts.Input.InputType.InputType.Mobile:
                    input = GetComponent<MobileInput>();
                    break;
            }
            
            input.ProvideInputs();
        }
        #endregion
    }
}