using UnityEngine;
using Input = WarGames_Defcon_1.Code.Scripts.Input.ClassicInput;

namespace WarGames_Defcon_1.Code.Scripts.Input.ClassicInput {
    public abstract class InputReceiver : MonoBehaviour {
        #region Fields
        [SerializeField] protected Scripts.Input.InputType.InputType selectedInputType = Scripts.Input.InputType.InputType.Keyboard;

        protected Scripts.Input.InputType.InputType inspectorInputType;
        #endregion

        

        #region Properties
        protected virtual Scripts.Input.InputType.InputType SelectedInputType {
            get => selectedInputType;
            set => inspectorInputType = selectedInputType = value;
        }
        #endregion
        
        

        #region Properties
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool CameraButton { get; private set; }
        public bool NextUnitButton { get; private set; }
        public bool CommandMenuButton { get; private set; }
        public bool PauseMenuButton { get; private set; }
        public bool SettingsMenuButton { get; private set; }
        public bool MainAttackButton { get; private set; }
        public bool AltAttackButton { get; private set; }
        #endregion


        
        #region Builtin Methdods
        protected void Awake() {
            
        }


        protected virtual void OnValidate() {
            if (inspectorInputType != selectedInputType) SelectedInputType = selectedInputType;
        }
        #endregion
        
        

        #region Custom Methods
        protected virtual void ApplyInputs(float horizontal, float vertical, bool cameraButton, bool nextUnitButton, bool commandMenuButton, bool pauseMenuButton, bool settingsMenuButton, bool mainAttackButton, bool altAttackButton) {
            Horizontal = horizontal;
            Vertical = vertical;
            CameraButton = cameraButton;
            NextUnitButton = nextUnitButton;
            CommandMenuButton = commandMenuButton;
            PauseMenuButton = pauseMenuButton;
            SettingsMenuButton = settingsMenuButton;
            MainAttackButton = mainAttackButton;
            AltAttackButton = altAttackButton;
        }

        
        protected virtual void SetInput(Scripts.Input.InputType.InputType type) {
            selectedInputType = type;

        }
    }
    #endregion
}