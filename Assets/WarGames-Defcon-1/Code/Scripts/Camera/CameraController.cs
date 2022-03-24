using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Camera {
    public class CameraController : MonoBehaviour {
        #region Fields
        [SerializeField] private Cameras currentCamera;
        [SerializeField] private MainCamera mainCamera;
        [SerializeField] private SimpleCamera playerCamera;

        private ICamera activeCamera;
        #endregion



        #region Properties
        public MainCamera MainCamera => mainCamera;
        public SimpleCamera PlayerCamera => playerCamera;
        #endregion
        
        

        #region Builtin Methods
        private void OnValidate() {
            switch (currentCamera) {
                case Cameras.mainCamera:
                    SwitchCamera(Cameras.mainCamera);
                    break;
                case Cameras.playerCamera:
                    SwitchCamera(Cameras.playerCamera);
                    break;
            }
        }
        #endregion
        
        
        
        #region Custom Methods
        public void SwitchCamera(Cameras camera) {
            switch (camera) {
                case Cameras.mainCamera:
                    mainCamera.gameObject.SetActive(true);
                    playerCamera.gameObject.SetActive(false);
                    break;
                case Cameras.playerCamera:
                    mainCamera.gameObject.SetActive(false);
                    playerCamera.gameObject.SetActive(true);
                    break;
            }
        }
        #endregion
    }
}