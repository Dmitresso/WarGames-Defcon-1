using System;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    [Serializable] public struct Keys {
        public string horizontal;
        public string vertical;


        public KeyCode camera;
        public KeyCode nextUnit;
        public KeyCode commandMenu;
        public KeyCode pauseMenu;
        public KeyCode settingsMenu;
        public KeyCode mainAttack;
        public KeyCode altAttack;


        public Keys(string horizontal,
                    string vertical,

                    KeyCode camera,
                    KeyCode nextUnit,
                    KeyCode commandMenu,
                    KeyCode pauseMenu,
                    KeyCode settingsMenu,
                    KeyCode mainAttack,
                    KeyCode altAttack) {
            this.horizontal = horizontal;
            this.vertical = vertical;
            
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