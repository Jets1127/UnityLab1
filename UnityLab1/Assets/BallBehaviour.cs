using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float xRotations = 0;
    public float yRotations = 1;
    public float zRotations = 0;
    public float degreesPerSecond = 180;
    public float numRotations = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(xRotations, yRotations++, zRotations);

        transform.RotateAround(Vector3.zero, axis, degreesPerSecond * Time.deltaTime);

        


        axis.x += axis.x + 1;
        //transform.position = axis;
        //degreesPerSecond += degreesPerSecond * Time.deltaTime;



    

        if(degreesPerSecond > 20000)
        {
            degreesPerSecond = 180;
        }

        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .25f);



    }
}
