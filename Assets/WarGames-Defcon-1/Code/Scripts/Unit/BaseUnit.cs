using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    [RequireComponent(typeof(Collider))]
    public abstract class BaseUnit : MonoBehaviour {
        #region FIELDS
        [SerializeField] protected bool playable;
        [SerializeField] protected bool destroyable;
        [SerializeField] protected float hp = 100f;
        #endregion
    }
}