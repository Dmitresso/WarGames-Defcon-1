﻿using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.UI {
    [RequireComponent(typeof(CanvasGroup))]
    public class Menu : MonoBehaviour {
        #region Variables
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