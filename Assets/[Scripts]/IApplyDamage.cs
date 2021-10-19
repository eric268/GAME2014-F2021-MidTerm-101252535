//--------------------------------------------------------------------------------
//------------------------------IApplyDamage.cs-----------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script contains an interface that is implemented
//             in the bullet controller class. It ensures that bullets 
//             have a ApplyDamage function.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface that ensures a class contains an apply damage function.
public interface IApplyDamage
{
    //Function that will apply damage to objects when hit by bullets.
    int ApplyDamage();
}
