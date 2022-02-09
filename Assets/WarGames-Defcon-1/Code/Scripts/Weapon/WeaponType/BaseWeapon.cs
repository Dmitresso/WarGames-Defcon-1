using UnityEngine;

namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    public class BaseWeapon : MonoBehaviour, IWeapon {
        #region Variables
        [SerializeField] private Transform muzzlePosition;
        [SerializeField] private GameObject projectile;
        [SerializeField] private int maxAmmoCount = 100;

        [SerializeField] private AudioClip fireClip;
        [SerializeField] private ParticleSystem muzzleFlash;

        protected ProjectilePool projectilePool;
        protected AudioSource audioSource;
        protected int currentAmmoCount;
        #endregion

        
        
        #region Builtin Methods
        private void Start() {
            projectilePool = GetComponent<ProjectilePool>();
            audioSource = GetComponent<AudioSource>();
            currentAmmoCount = maxAmmoCount;
        }
        #endregion
        
        

        #region Interface Methods
        public virtual void WeaponFire() {
            Fire();
        }

        public virtual void WeaponReload() {
            currentAmmoCount = maxAmmoCount;
        }
        #endregion



        #region Custom Methods
        protected void Fire() {
            if (currentAmmoCount != 0) {
                HandleProjectile();
                HandleAudio();
                HandleVFX();

                currentAmmoCount--;
                currentAmmoCount = Mathf.Clamp(currentAmmoCount, 0, maxAmmoCount);
            }
            else WeaponReload();
        }
        
        
        protected virtual void HandleProjectile() {
            projectilePool.GetPooledObject();
        }


        protected virtual void HandleAudio() {
            if (audioSource && fireClip) audioSource.PlayOneShot(fireClip);
        }


        protected virtual void HandleVFX() {
            if (muzzleFlash) muzzleFlash.Play();
            
        }
        #endregion
    }
}