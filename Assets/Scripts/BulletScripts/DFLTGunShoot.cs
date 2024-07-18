using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFLTGunShoot : MonoBehaviour
{

    public GameObject DefaultLaserPrefab;
    public Transform laserRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !PauseMenu.isPaused)
        {
            Instantiate(DefaultLaserPrefab, transform.position, laserRotation.rotation);
        }
    }
}
