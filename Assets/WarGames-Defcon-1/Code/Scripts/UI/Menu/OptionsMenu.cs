using UnityEngine;
using UnityEngine.UI;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public class OptionsMenu : Menu {
        #region Fields
        [SerializeField] private Button selectMissionButton;
        [SerializeField] private Image selectMissionImage;
        [SerializeField] private Button chooseGameTypeButton;
        [SerializeField] private Image chooseGameTypeImage;
        [SerializeField] private Button changeControlsButton;
        [SerializeField] private Image changeControlsImage;
        #endregion
    }
}