using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    [RequireComponent(typeof(Rigidbody),
        typeof(WeaponController))]
    public class Vehicle : Unit {
        #region FIELDS
        protected WeaponController weaponController;
        #endregion



        #region PROPERTIES
        public WeaponController WeaponController => weaponController;
        #endregion
        
        
        
        #region BUILTIN METHODS
        protected void Awake() {
            rb = GetComponent<Rigidbody>();
            weaponController = GetComponent<WeaponController>();
        }
        #endregion
    }
}