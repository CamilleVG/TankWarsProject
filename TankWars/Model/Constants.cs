﻿using System;
using TankWars;

namespace Model {

    /// <summary>
    /// A class that holds constants
    /// </summary>
    public class Constants {

        public static int HORIZONTAL = 1; // Signifies a wall has a horizontal orientation
        public static int VERTICAL = 0; // Signifies a wall has a vertical orientation

        public static int BEAMCOOLDOWN = 30;
        public static int BEAMLOOPTIMES = 3;
        public static int BEAMSIZELENGTH = (int)(VIEWSIZE * 1.41); // Maximum amount to stretch beam out ((VIEWSIZE * 1.41) will stretch to edge of clients screen)
        public static int BEAMSIZEWIDTH = TANKSIZE;
        public static int BEAMTIMESCALAR = 2; // How stretched out the animation time is
        public static int EXPLOSIONTIMESCALAR = 4; // How stretched out the animation time is
        public static int EXPLOSIONSIZE = 125;
        public static int HEALTHBARHEIGHT = 5;
        public static int HEALTHBARWIDTH = 45;
        public static int MaxHP = 3;
        public static int MAXPOWERUPS = 2;
        public static int MENUSIZE = 40;
        public static int POWERUPDELAY = 1650;
        public static int POWERUPINNER = 12; // Inner circle radius on a powerup
        public static int POWERUPOUTER = 18; // Outer circle radius and effective size of a powerup
        public static int PROJECTILESIZE = 30;
        public static int PROJECTILESPEED = 25;
        public static int TANKSIZE = 60;
        public static int TANKSPEED = 10;
        public static int TURRETSIZE = 50;
        public static int VIEWSIZE = 900;
        public static int WALLWIDTH = 50;
        public static Vector2D DOWN = new Vector2D(0, 1);
        public static Vector2D LEFT = new Vector2D(-1, 0);
        public static Vector2D RIGHT = new Vector2D(1, 0);
        public static Vector2D UP = new Vector2D(0, -1);
    }
}
