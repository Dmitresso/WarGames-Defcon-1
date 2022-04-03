using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public class MainMenu : Menu {
        #region Fields
        [Space]
        [SerializeField] private Button startButton;
        [SerializeField] private Image startButtonImage;
        
        [Space]
        [SerializeField] private Button optionsButton;
        [SerializeField] private Image optionsButtonImage;

        [Space]
        [SerializeField] private Image fractionLogo;
        [SerializeField] private TMP_Text gameType;
        
        [Space]
        [SerializeField] private Image missionImage;
        [SerializeField] private TMP_Text missionText;
        #endregion
    }
}