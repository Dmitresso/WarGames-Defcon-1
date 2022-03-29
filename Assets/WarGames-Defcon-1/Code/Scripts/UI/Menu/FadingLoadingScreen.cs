using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public class FadingLoadingScreen : LoadingScreen {
        #region FIELDS
        [SerializeField, Range(0.5f, 4f)] private float fadeDuration = 1.5f;
        [SerializeField] private Image fadeScreen;
        [SerializeField] private ProgressBar progressBar;
        [SerializeField] private TextMeshProUGUI loadingText;
        #endregion



        #region PROPERTIES
        private bool FadedIn => fadeScreen.canvasRenderer.GetAlpha() <= 0f;
        private bool FadedOut => fadeScreen.canvasRenderer.GetAlpha() >= 1f;
        #endregion
        
        
        
        #region CUSTOM METHODS
        public override IEnumerator StartLoading() {
            FadeIn();
            StartCoroutine(progressBar.StartLoading(progressBar.LoadingCompleted));
            StartCoroutine(FadeOut(progressBar.LoadingCompleted));
            StartCoroutine(SetReadyToUnload(FadedOut));
            yield return null;
        }

        
        private void FadeIn() {
            fadeScreen.CrossFadeAlpha(0, fadeDuration, false);
        }
    
        
        private IEnumerator FadeOut(bool waitUntilTrue) {
            yield return new WaitUntil(() => waitUntilTrue);
            fadeScreen.CrossFadeAlpha(1, fadeDuration, false);
        }
        #endregion
    }
}