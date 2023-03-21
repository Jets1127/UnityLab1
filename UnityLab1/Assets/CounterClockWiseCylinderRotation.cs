using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterClockWiseCylinderRotation : MonoBehaviour
{
    public float xRots = 1;
    public float yRots = 0;
    public float zRots = 0;
    public float degreesPerSecon = -180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(xRots, yRots, zRots);

        transform.Rotate(axis, degreesPerSecon * Time.deltaTime);

        degreesPerSecon += degreesPerSecon;

        if (degreesPerSecon < -1800)
        {
            degreesPerSecon = -180;
        }

        
    }
}
