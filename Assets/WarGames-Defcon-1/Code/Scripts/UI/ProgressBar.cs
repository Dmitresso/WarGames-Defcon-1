using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using WarGames_Defcon_1.Code.Scripts.UI.Menu;


namespace WarGames_Defcon_1.Code.Scripts.UI {
    public class ProgressBar : MonoBehaviour {
        #region FIELDS
        [SerializeField, Range(1f, 5f)] public float duration = 2f;
        [SerializeField, Range(0.1f, 2f)] public float rate = 0.5f;
        [SerializeField] private LoadingScreen loadScreen;
        [SerializeField] private Slider slider;
        #endregion



        #region PROPERTIES
        public bool LoadingCompleted => slider.value >= slider.maxValue;
        #endregion



        #region CUSTOM METHODS
        public IEnumerator StartLoading(bool waitUntilTrue) {
            yield return new WaitUntil(() => waitUntilTrue);
            while (!LoadingCompleted) {
                var i = (slider.maxValue - slider.value) * rate / duration;
                slider.value += i;
                duration -= rate;
                yield return new WaitForSeconds(rate);
            }
        }
        #endregion
    }
}