//--------------------------------------------------------------------------------
//------------------------------BulletFactory.cs--------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script creates different types of bullets for the 
//             BulletManager class. These bullets are randomly generated
//             amongst three different types of bullets.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that handles creation of the players bullets for the bullet pool
[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;

    //Creates a random bullet based upon three bullet types
    public GameObject createBullet(BulletType type = BulletType.RANDOM)
    {
        if (type == BulletType.RANDOM)
        {
            var randomBullet = Random.Range(0, 3);
            type = (BulletType) randomBullet;
        }

        GameObject tempBullet = null;
        //Selects between the bullet type enumeration 
        switch (type)
        {
            case BulletType.REGULAR:
                tempBullet = Instantiate(regularBullet);
                tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case BulletType.FAT:
                tempBullet = Instantiate(fatBullet);
                tempBullet.GetComponent<BulletController>().damage = 20;
                break;
            case BulletType.PULSING:
                tempBullet = Instantiate(pulsingBullet);
                tempBullet.GetComponent<BulletController>().damage = 30;
                break;
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}
