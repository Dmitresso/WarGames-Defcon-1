using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    [RequireComponent(typeof(Rigidbody),
                     typeof(SphereCollider))]
    public class BaseProjectile : MonoBehaviour {
        #region Fields
        [SerializeField] private float speed = 200f;
        [SerializeField] private float damage = 10f;

        protected Rigidbody rb;
        protected SphereCollider collider;
        #endregion


        #region Properties
        public float Speed => speed;
        #endregion
        
        

        #region Builtin Methods
        private void Awake() {
            rb = GetComponent<Rigidbody>();
            collider = GetComponent<SphereCollider>();
        }


        private void OnEnable() {
            if (rb) FireProjectile();
        }


        private void OnDisable() {
            if (rb) rb.velocity = Vector3.zero;
        }
        #endregion



        #region Custom Methods
        public void FireProjectile() {
            rb.AddForce(transform.forward * speed, ForceMode.Impulse);
        }
        #endregion
    }
}