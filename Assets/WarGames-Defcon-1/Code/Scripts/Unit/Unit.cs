using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    [RequireComponent(typeof(WeaponController))]
    public abstract class Unit : MonoBehaviour {
        #region Fields
        [SerializeField] protected bool playable;
        [SerializeField] protected float hp = 100f;
        [SerializeField] protected float armor = 0f;
        [SerializeField] protected float speed = 10f;

        protected WeaponController weapon;
        #endregion



        #region Properties
        public bool Playable => playable;
        public float Speed => speed;
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