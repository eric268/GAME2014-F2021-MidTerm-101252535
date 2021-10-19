//--------------------------------------------------------------------------------
//------------------------------BulletController.cs-------------------------------
//------------------------------Eric Galway---------------------------------------
//------------------------------101252535-----------------------------------------
//------------------------------Last Modified: 18/10/2021-------------------------
//------------------------------Description---------------------------------------
//             This script controls the behavior of the bullets. It
//             moves these bullets horizontally across the screen.
//------------------------------Revision History----------------------------------
//------------------------------Version 1.0 - original File-----------------------
//------------------------------Version 1.1 - Bullets now move from left to right-

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that encapsulates all bullet movement. It implements the IApplyDamage interface
public class BulletController : MonoBehaviour, IApplyDamage
{
    [SerializeField]
    public float horizontalSpeed;
    [SerializeField]
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
        horizontalSpeed = 2.0f;
        horizontalBoundary = 11.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //Moves the bullets according to their movement speed
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }
    //Returns bullet to Queue and deactivates its movement if it moves off the right side of the screen
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
    //Checks for collision and deactivates & returns bullet to Queue if true
    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
