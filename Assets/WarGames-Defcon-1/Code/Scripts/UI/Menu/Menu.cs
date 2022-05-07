using UnityEngine;
using UnityEngine.UI;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    [RequireComponent(typeof(Canvas),
        typeof(CanvasGroup),
        typeof(GraphicRaycaster))]
    public class Menu : MonoBehaviour {
        #region FIELDS
        [SerializeField] protected Canvas canvas;
        [SerializeField] protected CanvasGroup canvasGroup;
        
        private int layer;
        #endregion



        #region PROPERTIES
        public float Visibility {
            get => canvasGroup.alpha;
            set => canvasGroup.alpha = value;
        }
        #endregion



        #region BUILTIN METHODS
        private void Awake() {
            layer = LayerMask.NameToLayer("UI");
            gameObject.layer = layer;
        }
        #endregion
    }
}