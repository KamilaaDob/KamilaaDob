using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionPointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float camera_angle =  Camera.main.transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0,camera_angle,0); 
    }
}
