using UnityEngine;

namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    [RequireComponent(typeof(CanvasGroup))]
    public class Menu : MonoBehaviour {
        #region Fields
        private CanvasGroup canvasGroup;
        #endregion



        #region Properties
        public float Visibility {
            get => canvasGroup.alpha;
            set => canvasGroup.alpha = value;
        }
        #endregion
    }
}