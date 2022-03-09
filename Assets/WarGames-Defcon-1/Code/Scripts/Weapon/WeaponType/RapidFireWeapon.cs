using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Weapon.Projectile.ProjectilePool;
using WarGames_Defcon_1.Code.Scripts.Weapon.WeaponType;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    [RequireComponent(typeof(AdvancedProjectilePool))]
    public class RapidFireWeapon : BaseWeapon {
        #region Fields

        private float lastFireTime;
        #endregion



        #region Builtin Methods
        private void Awake() {
            
        }
        #endregion



        #region Override Methods
        public override void WeaponFire() {
            if (Time.time >= lastFireTime + fireRate) {
                Fire();
                lastFireTime = Time.time;
            }
        }
        #endregion
    }
}