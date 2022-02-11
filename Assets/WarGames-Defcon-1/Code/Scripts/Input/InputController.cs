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


        [Header("Input Events")]
        public UnityEvent onCameraButtonPressed = new();
        #endregion


        #region Properties
        public float Horizontal => horizontal;
        public float Vertical => vertical;
        
        public bool CameraButton => cameraButton;
        #endregion
        


        #region Builtin Methods
        private void Start() {
            keyboardInput = GetComponent<KeyboardInput>();
            if (keyboardInput) SetInput(inputType);
        }

        
        private void Update() {
            horizontal = keyboardInput.Horizontal;
            vertical = keyboardInput.Vertical;
            
            
            cameraButton = keyboardInput.CameraButton;
            if (cameraButton) onCameraButtonPressed?.Invoke();
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