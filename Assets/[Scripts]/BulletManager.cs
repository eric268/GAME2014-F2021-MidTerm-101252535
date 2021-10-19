//--------------------------------------------------------------------------------
//------------------------------BulletManager.cs----------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script creates and activates/deactivates 
//             all bullets in the bullet pool.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that encapsulates the creation and control of all bullets in the bullet pool
[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public BulletFactory bulletFactory;
    public int MaxBullets;

    private Queue<GameObject> m_bulletPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildBulletPool();
    }

    //Creates a Queue to store all bullets and populates this Queue 
    private void _BuildBulletPool()
    {
        // create empty Queue structure
        m_bulletPool = new Queue<GameObject>();

        for (int count = 0; count < MaxBullets; count++)
        {
            var tempBullet = bulletFactory.createBullet();
            m_bulletPool.Enqueue(tempBullet);
        }
    }
    //Removes the first bullet in the Queue and sets its position and activates it.
    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_bulletPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }
    //Checks if the bullet pool is not empty
    public bool HasBullets()
    {
        return m_bulletPool.Count > 0;
    }
    //Adds a bullet to the Queue and deactivates it
    public void ReturnBullet(GameObject returnedBullet)
    {
        returnedBullet.SetActive(false);
        m_bulletPool.Enqueue(returnedBullet);
    }
}
