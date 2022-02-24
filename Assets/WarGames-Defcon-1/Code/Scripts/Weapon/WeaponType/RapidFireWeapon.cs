using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Weapon.Projectile.ProjectilePool;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    [RequireComponent(typeof(AdvancedProjectilePool))]
    public class RapidFireWeapon : BaseWeapon {
        #region Fields

        [Header("Rapid Fire Properties")] public float fireRate = 0.15f;
        public float lastFireTime;
        #endregion



        #region Builtin Methods

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