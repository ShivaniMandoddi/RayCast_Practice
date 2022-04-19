using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public float rotationSpeed;
    public Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(inputX, 0f, inputZ);

        // PLayer Rotation
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(0f, mouseX, 0f);
        // Cam Rotation
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        cam.transform.Rotate(-mouseY, 0f, 0f);
    }
}
