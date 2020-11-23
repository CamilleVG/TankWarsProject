﻿using System;

namespace Model {

    /// <summary>
    /// A class that holds constants
    /// </summary>
    public class Constants {

        public static int MaxHP = 3;
        public static int HORIZONTAL = 1; // Signifies a wall has a horizontal orientation
        public static int VERTICAL = 0; // Signifies a wall has a vertical orientation
        public static int WALLWIDTH = 50;
        public static int VIEWSIZE = 900;
        public static int MENUSIZE = 40;
        public static int TANKSIZE = 60;
        public static int TURRETSIZE = 50;
        public static int PROJECTILESIZE = 30;
        public static int POWERUPOUTER = 18;
        public static int POWERUPINNER = 12;
        public static int EXPLOSIONTIMESCALAR = 4; // How stretched out the animation time is
        public static int EXPLOSIONSIZE = 125;
        public static int BEAMTIMESCALAR = 2; // How stretched out the animation time is
        public static int BEAMSIZELENGTH = (int)(VIEWSIZE * 1.41);
        public static int BEAMSIZEWIDTH = TANKSIZE;
        public static int BEAMLOOPTIMES = 3;
        public static int HEALTHBARHEIGHT = 5;
        public static int HEALTHBARWIDTH = 45;
    }
}
