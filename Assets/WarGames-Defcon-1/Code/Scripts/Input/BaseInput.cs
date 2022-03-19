using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    [DisallowMultipleComponent]
    public abstract class BaseInput : MonoBehaviour {
        #region Fields
        [SerializeField] protected bool oneAttackHeld = true;
        [Range(minDelay, maxDelay)] protected float mainAttackDelay = 1f;
        [Range(minDelay, maxDelay)] protected float alternateAttackDelay = 1f;

        
        protected bool mainAttackHeld;
        protected bool alternateAttackHeld;
        protected bool moveHeld;
        protected bool rotateHeld;


        protected Coroutine mainAttackCoroutine;
        protected Coroutine alternateAttackCoroutine;
        protected Coroutine moveCoroutine;
        protected Coroutine rotateCoroutine;
        #endregion



        #region Constants
        private const float minDelay = 0.1f;
        private const float maxDelay = 1.5f;
        #endregion
        

        
        #region Properties
        public float MainAttackDelay {
            get => mainAttackDelay;
            set {
                value = value switch {
                    < minDelay => minDelay,
                    > maxDelay => maxDelay,
                    _ => value
                };
            }
        }

        public float AlternateAttackDelay {
            get => alternateAttackDelay;
            set {
                value = value switch {
                    < minDelay => minDelay,
                    > maxDelay => maxDelay,
                    _ => value
                };
            }
        }
        
        public InputController Input { get; private set; }
        #endregion

        

        #region Builtin Methods
        protected void Awake() {
            Input = new InputController();
            
            Input.Player.Move.performed += OnMovePerform;
            Input.Player.Move.canceled += context => OnMoveCancel();

            Input.Player.Rotate.performed += OnRotatePerform;
            Input.Player.Rotate.canceled += context => OnRotateCancel();
            
            Input.Player.MainAttack.performed += context => OnMainAttackPerform();
            Input.Player.MainAttack.canceled += context => OnMainAttackCancel();
            
            Input.Player.AlternateAttack.performed += context => OnAlternateAttackPerform();
            Input.Player.AlternateAttack.canceled += context => OnAlternateAttackCancel();
            
            Input.Player.ChangeUnit.performed += OnChangeUnit;
            Input.Player.ChangeView.performed += OnChangeView;
            
            Input.Player.CommandMenu.performed += OnCommandMenu;
            Input.Player.CommandCenterMenu.performed += OnCommandCenterMenu;
            Input.Player.SettingsMenu.performed += OnSettingsMenu;
        }

        
        private void OnEnable() {
            Input.UI.Enable();
        }

        
        private void OnDisable() {
            StopAllCoroutines();
            Input.UI.Disable();
        }
        #endregion



        #region Custom Methods
        protected virtual void OnMovePerform(InputAction.CallbackContext context) {
            moveHeld = true;
            moveCoroutine = StartCoroutine(Move(context.ReadValue<Vector2>()));
        }


        protected virtual void OnMoveCancel() {
            if (moveHeld) moveHeld = false;
            if (moveCoroutine != null) StopCoroutine(moveCoroutine);
        }


        protected virtual IEnumerator Move(Vector2 direction) {
            yield return new WaitForFixedUpdate();
        }
        

        protected virtual void OnRotatePerform(InputAction.CallbackContext context) {
            rotateHeld = true;
            rotateCoroutine = StartCoroutine(Rotate(context.ReadValue<Vector2>()));
        }
        
        
        protected virtual void OnRotateCancel() {
            rotateHeld = false;
            if (rotateCoroutine != null) StopCoroutine(rotateCoroutine);
        }


        protected virtual IEnumerator Rotate(Vector2 direction) {
            yield return new WaitForFixedUpdate();
        }
        
        
        protected virtual void OnMainAttackPerform() {
            Debug.Log("[InputController] HandleMainAttackPerform()");
            mainAttackHeld = true;
            if (oneAttackHeld) alternateAttackHeld = false;
            mainAttackCoroutine = StartCoroutine(nameof(MainAttack));
        }
        
        
        protected virtual void OnMainAttackCancel() {
            Debug.Log("[InputController] HandleMainAttackCancel()");
            if (mainAttackHeld) mainAttackHeld = false;
            if (mainAttackCoroutine != null) StopCoroutine(mainAttackCoroutine);
        }
        
        
        protected virtual IEnumerator MainAttack() {
            while (mainAttackHeld) yield return new WaitForSeconds(mainAttackDelay);
        }

        
        protected virtual void OnAlternateAttackPerform() {
            Debug.Log("[InputController] HandleAlternateAttackPerform()");
            alternateAttackHeld = true;
            if (oneAttackHeld) mainAttackHeld = false;
            alternateAttackCoroutine = StartCoroutine(nameof(AlternateAttack));
        }

        
        protected virtual void OnAlternateAttackCancel() {
            Debug.Log("[InputController] HandleAlternateAttackCancel()");
            if (alternateAttackHeld) alternateAttackHeld = false;
            if (alternateAttackCoroutine != null) StopCoroutine(alternateAttackCoroutine);
        }
        
        
        protected virtual IEnumerator AlternateAttack() {
            while (alternateAttackHeld) yield return new WaitForSeconds(alternateAttackDelay);
        }
        

        protected virtual void OnChangeUnit(InputAction.CallbackContext context) { }

        
        protected virtual void OnChangeView(InputAction.CallbackContext context) { }

        
        protected virtual void OnCommandMenu(InputAction.CallbackContext context) { }

        
        protected virtual void OnCommandCenterMenu(InputAction.CallbackContext context) { }

        
        protected virtual void OnSettingsMenu(InputAction.CallbackContext context) { }
        #endregion
    }
}