using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

	public float jumpForce = 10f; 
    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) 
         {
         	Jump();
         }
    }
    void Jump()
    {
    	rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
