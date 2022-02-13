using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    public abstract class Unit : MonoBehaviour {
        #region Variables
        [SerializeField] private WeaponController weapon;
        [SerializeField] private bool playable;
        
        protected float hp = 100f;
        protected float armor = 0f;
        protected float speed = 10f;
        #endregion



        #region Builtin Methods
        private void Start() {
            weapon = GetComponent<WeaponController>();
        }
        #endregion
        
        
        
        #region Custom Methods
        public virtual void UpdateAnimation(Animator animator) {
            
        }


        public virtual void UpdateWeapon(InputController input) {
            weapon.UpdateWeapon(input);
        }
        #endregion
    }
}