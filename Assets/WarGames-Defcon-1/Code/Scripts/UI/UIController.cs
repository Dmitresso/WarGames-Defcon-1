using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.UI.Menu;


namespace WarGames_Defcon_1.Code.Scripts.UI {
    public class UIController : Singleton<UIController> {
        #region Fields
        [SerializeField] private MainMenu mainMenu;
        [SerializeField] private OptionsMenu optionsMenu;
        [SerializeField] private CommandMenu commandMenu;
        [SerializeField] private CommandCenterMenu commandCenterMenu;
        [SerializeField] private SettingsMenu settingsMenu;
        [SerializeField] private ExitMenu exitMenu;
        #endregion
    }
}