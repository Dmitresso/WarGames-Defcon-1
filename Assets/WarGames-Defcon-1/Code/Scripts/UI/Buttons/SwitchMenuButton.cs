using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.UI.Buttons {
    public class SwitchMenuButton : MonoBehaviour {
        #region CUSTOM METHODS
        public void SwitchMenu(Menu.Menu from, Menu.Menu to) {
            from.gameObject.SetActive(false);
            to.gameObject.SetActive(true);
        }
        #endregion
    }
}