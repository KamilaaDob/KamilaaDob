using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

	 public float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 cameraMovement = new Vector3(mouseX, 0, mouseY) * movementSpeed * Time.deltaTime;
        transform.Translate(cameraMovement, Space.World);
    }
}
