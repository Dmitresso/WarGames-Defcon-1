using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    public abstract class Unit : MonoBehaviour {
        #region Variables
        [SerializeField] private bool playable;
        
        private float hp = 100f;
        private float armor = 0f;
        private float speed = 10f;
        #endregion

        

        #region Custom Methods
        public void UpdateAnimation(Animator animator) {
            
        }


        protected void Test() {
            
        }
        #endregion
    }
}