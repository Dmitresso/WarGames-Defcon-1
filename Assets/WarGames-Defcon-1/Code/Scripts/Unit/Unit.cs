using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Input.ClassicInput;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    [RequireComponent(typeof(WeaponController))]
    public abstract class Unit : MonoBehaviour {
        #region Variables
        [SerializeField] protected bool playable;

        protected WeaponController weapon;
        protected float hp = 100f;
        protected float armor = 0f;
        protected float speed = 10f;
        #endregion



        #region Builtin Methods
        private void Awake() {
            weapon = GetComponent<WeaponController>();
        }
        #endregion
        
        
        
        #region Custom Methods
        public virtual void UpdateAnimation(Animator animator) {
            
        }


        // public virtual void UpdateWeapon(InputController input) {
        //     weapon.UpdateWeapon(input);
        // }
        #endregion
    }
}