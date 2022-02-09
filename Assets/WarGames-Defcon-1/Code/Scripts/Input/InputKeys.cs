using System;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    [Serializable] public struct InputKeys {
        public string horizontal;
        public string vertical;

        public KeyCode moveForward;
        public KeyCode moveBackward;
        public KeyCode moveLeft;
        public KeyCode moveRight;
        public KeyCode camera;
        public KeyCode nextUnit;
        public KeyCode commandMenu;
        public KeyCode pauseMenu;
        public KeyCode settingsMenu;
        public KeyCode mainAttack;
        public KeyCode altAttack;


        public InputKeys(string horizontal,
                         string vertical,
                         KeyCode moveForward,
                         KeyCode moveBackward,
                         KeyCode moveLeft,
                         KeyCode moveRight,
                         KeyCode camera,
                         KeyCode nextUnit,
                         KeyCode commandMenu,
                         KeyCode pauseMenu,
                         KeyCode settingsMenu,
                         KeyCode mainAttack,
                         KeyCode altAttack) {
            this.horizontal = horizontal;
            this.vertical = vertical;
            
            this.moveForward = moveForward;
            this.moveBackward = moveBackward;
            this.moveLeft = moveLeft;
            this.moveRight = moveRight;
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