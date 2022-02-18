using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Weapon.Projectile.ProjectilePool {
    public class AdvancedProjectilePool : ProjectilePool {
        #region Variables
        [Tooltip("Calculate pool size automatically according to \"utilizeDistance\", \"projectileSpeed\" and \"weaponFireRate\" values. True by default.")]
        public bool calculateOptimalPoolSize = true;

        private RapidFireWeapon weapon;
        #endregion



        #region Builtin Methods
        private void Awake() {
            weapon = GetComponent<RapidFireWeapon>();
        }

        
        private void Start() {
            var projectile = pooledGO.GetComponent<BaseProjectile>();

            if (calculateOptimalPoolSize) {
                size = CalculatePoolSize(utilizeDistance, projectile.Speed, weapon.fireRate);
            }
            FillPool(size, pooledGO, parentGO);
        }
        #endregion



        #region Custom Methods
        private int CalculatePoolSize(float utilizeDistance, float projectileSpeed, float weaponFireRate) {
            return Mathf.RoundToInt(utilizeDistance / projectileSpeed / weaponFireRate) + 1;
        }
        #endregion
    }
}
