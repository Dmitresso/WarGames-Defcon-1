using System.Collections;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public delegate void LoadingFinished();
    public class LoadingScreen : Menu {
        #region FIELDS
        public event LoadingFinished LoadingFinished;
        #endregion



        #region CUSTOM METHODS
        public virtual IEnumerator StartLoading() {
            yield return null;
        }


        protected virtual IEnumerator SetReadyToUnload(bool condition) {
            yield return new WaitUntil(() => condition);
            OnLoadingFinished();
        }


        protected virtual void OnLoadingFinished() {
            LoadingFinished?.Invoke();
        }
        #endregion
    }
}