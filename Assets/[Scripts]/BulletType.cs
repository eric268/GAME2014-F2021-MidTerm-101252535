//--------------------------------------------------------------------------------
//------------------------------BulletTypes.cs--------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script contains an enumeration for different bullet
//             types. Currently these bullet types are fired only by the
//             player.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enumeration for different types of player bullets.
[System.Serializable]
public enum BulletType
{
    REGULAR,
    FAT,
    PULSING,
    RANDOM
}
