using UnityEngine;
using UnityEngine.UI;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public class SettingsMenu : Menu {
        #region Fields
        [SerializeField] private Button musicVolumeButton;
        [SerializeField] private Image musicVolumeButtonImage;
        [SerializeField] private Slider musicVolumeSlider;
        [Space]
        [SerializeField] private Button sfxVolumeButton;
        [SerializeField] private Image sfxVolumeButtonImage;
        [SerializeField] private Slider sfxVolumeSlider;
        [Space]
        [SerializeField] private Button voiceVolumeButton;
        [SerializeField] private Image voiceVolumeButtonImage;
        [SerializeField] private Slider voiceVolumeSlider;
        [Space]
        [SerializeField] private Button exitButton;
        [SerializeField] private Image exitButtonImage;
        #endregion
    }
}