using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.UI;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    public class UIController : Singleton<UIController> {
        #region Variables
        [SerializeField] private CommandMenu commandMenu;
        [SerializeField] private PauseMenu pauseMenu;
        [SerializeField] private SettingsMenu settingsMenu;
        #endregion
    }
}