using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using WarGames_Defcon_1.Code.Scripts.Camera;
using WarGames_Defcon_1.Code.Scripts.Game_Management;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Unit;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [DefaultExecutionOrder(-50)]
    [RequireComponent(typeof(DontDestroyOnLoad),
                     typeof(PlayerInput),
                     typeof(Animator))]
    public class PlayerController : BaseInput {
        #region Fields
        public Action<Vehicle> onUnitChanged;
        private SimpleCamera camera;

        private LevelManager currentLevelManager;
        private List<Vehicle> units;
        private int currentUnitIndex;
        private Rigidbody rb;
        private Transform transform;
        private float moveForce;
        private float torqueForce;
        
        private Animator animator;
        #endregion



        #region Properties
        private Vehicle CurrentUnit { get; set; }
        //private LevelManager сurrentLevelManager => GameObject.FindGameObjectWithTag(Tags.GM.LevelManager).GetComponent<LevelManager>();
        #endregion
        
        

        #region Builtin Methods
        protected void Awake() {
            base.Awake();
            animator = GetComponent<Animator>();

            onUnitChanged += SwitchUnit;
            
            camera = GameObject.FindGameObjectWithTag(Tags.GM.CameraController).GetComponent<CameraController>().PlayerCamera;
        }


        private void Start() {
            // units = (List<Vehicle>) сurrentLevelManager.LevelVehicles;
            return;
            
            units = (List<Vehicle>) GameManager.Instance.GetActiveSceneLevelManager().LevelVehicles;
            
            
            if (units.Count > 0) {
                for (var i = 0; i < units.Capacity - 1; i++) {
                    if (units[i] != null) {
                        currentUnitIndex = i;
                        CurrentUnit = units[i];
                        ApplyUnitParams(CurrentUnit);
                        Debug.Log("[PlayerController] currentUnit.name: " + CurrentUnit.name);
                        break;
                    }
                    if (i == units.Capacity - 1 && CurrentUnit == null) Debug.LogError("[PlayerController] \"units\" list doesn't contain any Unit.");
                }
            }
        }
        #endregion



        #region Custom Methods
        protected override IEnumerator Move(Vector2 direction) {
            while (moveHeld) {
                var finalDirection = direction.y * transform.forward;
                var force = rb.mass * moveForce * finalDirection;
                rb.AddForce(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator Rotate(Vector2 direction) {
            while (rotateHeld) {
                var force = rb.mass * torqueForce * direction.x * transform.up;
                rb.AddTorque(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator MainAttack() {
            while (mainAttackHeld) {
                Debug.Log("[PlayerController] MainAttack");
                yield return new WaitForSeconds(mainAttackDelay);
            }
        }


        protected override IEnumerator AlternateAttack() {
            while (alternateAttackHeld) {
                Debug.Log("[PlayerController] AlternateAttack");
                yield return new WaitForSeconds(AlternateAttackDelay);
            }
        }


        protected override void OnChangeUnit(InputAction.CallbackContext context) {
            onUnitChanged?.Invoke(CurrentUnit);
        }

        
        protected override void OnChangeView(InputAction.CallbackContext context) {
            camera.SwitchFollowDistance();
        }

        
        protected override void OnCommandMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnCommandMenu");
        }

        
        protected override void OnCommandCenterMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnCommandCenterMenu");
        }

        
        protected override void OnSettingsMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnSettingsMenu");
        }

        
        private void SwitchUnit(Vehicle unit) {
            if (units.Count <= 1) return;
            currentUnitIndex++;
            if (currentUnitIndex == units.Capacity) currentUnitIndex = 0;
                
            var nextUnit = units[currentUnitIndex];
            if (nextUnit != null && nextUnit.Playable) CurrentUnit = nextUnit;
            ApplyUnitParams(unit);
        }


        private void ApplyUnitParams(Unit.Unit unit) {
            rb = unit.RB;
            transform = unit.transform;
            moveForce = unit.MoveSpeed;
            torqueForce = unit.RotationSpeed;
            mainAttackDelay = unit.WeaponController.MainWeapon.FireRate;
            alternateAttackDelay = unit.WeaponController.AltWeapon.FireRate;
        }
        #endregion
    }
}