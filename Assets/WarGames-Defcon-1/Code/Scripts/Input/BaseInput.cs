using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public class BaseInput : MonoBehaviour {
        [SerializeField] private InputKeys InputKeys = new InputKeys(
            KeyCode.W,
            KeyCode.S,
            KeyCode.A,
            KeyCode.D,
            KeyCode.Q,
            KeyCode.E,
            KeyCode.C,
            KeyCode.V,
            KeyCode.F,
            KeyCode.Mouse0,
            KeyCode.Mouse1
            );
    }
}