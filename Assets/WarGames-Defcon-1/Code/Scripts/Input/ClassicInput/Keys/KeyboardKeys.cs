using System;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input.Keys {
    [Serializable] public struct KeyboardKeys : IKeys {
        public string Horizontal { get; set; }
        public string Vertical { get; set; }


        public KeyCode camera;
        public KeyCode nextUnit;
        public KeyCode commandMenu;
        public KeyCode pauseMenu;
        public KeyCode settingsMenu;
        public KeyCode mainAttack;
        public KeyCode altAttack;


        public KeyboardKeys(
                    string horizontal,
                    string vertical,

                    KeyCode camera,
                    KeyCode nextUnit,
                    KeyCode commandMenu,
                    KeyCode pauseMenu,
                    KeyCode settingsMenu,
                    KeyCode mainAttack,
                    KeyCode altAttack) {
            Horizontal = horizontal;
            Vertical = vertical;
            
            this.camera = camera;
            this.nextUnit = nextUnit;
            this.commandMenu = commandMenu;
            this.pauseMenu = pauseMenu;
            this.settingsMenu = settingsMenu;
            this.mainAttack = mainAttack;
            this.altAttack = altAttack;
        }
    }
}