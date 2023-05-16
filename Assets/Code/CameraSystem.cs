using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
	public GameObject ball;
    public float sense_x;
    public float sense_y;

    public void RotateCameraByMouse(Vector2 mouse_input)
    {
        transform.eulerAngles+= new Vector3(-mouse_input.y*sense_x ,mouse_input.x*sense_y,0)*Time.deltaTime;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        transform.position = ball.transform.position;
    }
}
