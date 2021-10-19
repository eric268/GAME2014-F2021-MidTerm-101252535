//--------------------------------------------------------------------------------
//------------------------------EnemyController.cs--------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script controls the behavior of the enemy ships. 
//             It moves them vertically and adds vertical bounds checking.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------
//------------------------------Version 1.1 - Switched to vertical movement-------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Class that encapsulates script for controlling enemy movement
public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //Updates the enemy position based upon direction and speed
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    //Flips the enemies current direction if it reaches the top or bottom boundary 
    private void _CheckBounds()
    {
        // check bottom boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check top boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
