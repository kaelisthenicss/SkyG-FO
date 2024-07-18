using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFLTGunShoot : MonoBehaviour
{

    public GameObject DefaultLaserPrefab;
    public Transform laserRotation;
    public bool canShoot;
    public float shootDelay;

    void Start()
    {
        canShoot = true;
        shootDelay = 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (shootDelay > 0f)
        {
            shootDelay -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") && !PauseMenu.isPaused)
        {
            if(canShoot)
            {
                ShootLaser();
                canShoot = false;
            }
            

            if (shootDelay <= 0f)
            {
                canShoot = true;
                shootDelay = 0.5f;
            }
        }
    }

    public void ShootLaser()
    {
        Instantiate(DefaultLaserPrefab, transform.position, laserRotation.rotation);
    }
}
