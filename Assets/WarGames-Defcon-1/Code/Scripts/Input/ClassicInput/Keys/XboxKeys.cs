using System;


namespace WarGames_Defcon_1.Code.Scripts.Input.Keys {
    [Serializable] public struct XboxKeys : IKeys {
        public string Horizontal { get; set; }
        public string Vertical { get; set; }
        
        public string camera;
        public string nextUnit;
        public string commandMenu;
        public string pauseMenu;
        public string settingsMenu;
        public string mainAttack;
        public string altAttack;


        public XboxKeys(
            string horizontal,
            string vertical,

            string camera,
            string nextUnit,
            string commandMenu,
            string pauseMenu,
            string settingsMenu,
            string mainAttack,
            string altAttack) {
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