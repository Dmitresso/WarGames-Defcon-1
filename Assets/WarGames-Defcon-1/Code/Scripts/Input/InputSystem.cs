using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public abstract class InputSystem : MonoBehaviour {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool CameraButton { get; private set; }
        public bool NextUnitButton { get; private set; }
        public bool CommandMenuButton { get; private set; }
        public bool PauseMenuButton { get; private set; }
        public bool SettingsMenuButton { get; private set; }
        public bool MainAttackButton { get; private set; }
        public bool AltAttackButton { get; private set; }

        public virtual void ApplyInputs(float horizontal, float vertical, bool cameraButton, bool nextUnitButton, bool commandMenuButton, bool pauseMenuButton, bool settingsMenuButton, bool mainAttackButton, bool altAttackButton) {
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
    }
}