//--------------------------------------------------------------------------------
//------------------------------BackgroundController.cs---------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script controls the behavior of the scrolling  
//             background. It currently scrolls from right to left
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------
//------------------------------Version 1.1 - Switched to right to left movement--

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that encapsulates the controller for moving the background images
public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //Moves the image to its starting position
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }
    //Moves the image from right to left based upon horizontal movement speed.
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }
    //Checks to see if the background has moved off the screen.
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
