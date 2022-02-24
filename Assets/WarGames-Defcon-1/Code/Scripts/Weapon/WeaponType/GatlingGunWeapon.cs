using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    public class GatlingGunWeapon : RapidFireWeapon {
        #region Fields
        public Transform barrelGO;
        public float rotationSpeed = 15f;
        public float slowDownSpeed = 5f;

        private float lastRotationSpeed;
        #endregion
        
        
        
        #region Builtin Methods
        private void Update() {
            if (!barrelGO) return;
            lastRotationSpeed -= slowDownSpeed * Time.deltaTime;
            lastRotationSpeed = Mathf.Clamp(lastRotationSpeed, 0f, rotationSpeed);
            barrelGO.Rotate(Vector3.up, lastRotationSpeed);
        }
        #endregion
        
        
        

        #region Override Methods
        public override void WeaponFire() {
            base.WeaponFire();

            if (!barrelGO) return;
            barrelGO.Rotate(Vector3.up, rotationSpeed);
            lastRotationSpeed = rotationSpeed;
        }
        #endregion
    }
}