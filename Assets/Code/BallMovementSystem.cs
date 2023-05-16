using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementSystem : MonoBehaviour
{

    public Rigidbody ball_physics;
    public float move_speed;
    public GameObject direction_pointer;
    public Vector2 keyboard_input;


    public void ReadKeyaboard()
    {
    	keyboard_input.x = Input.GetAxis("Horizontal");
		keyboard_input.y = Input.GetAxis("Vertical");


    }

    public void MoveByWorldAxis(  Vector3 direction_and_speed  )
    {
    	ball_physics.AddForce( direction_and_speed * move_speed * Time.deltaTime );

    }
    public void MoveByDirectionPointer(  Vector3 direction_and_speed  )
    {

        var converted_direction_and_speed = direction_pointer.transform.TransformDirection( direction_and_speed );

        ball_physics.AddForce( converted_direction_and_speed * move_speed * Time.deltaTime );
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	ReadKeyaboard();
        MoveByWorldAxis(new Vector3(keyboard_input.x,0,keyboard_input.y));
    }
}
