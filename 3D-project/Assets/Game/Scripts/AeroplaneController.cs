using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeroplaneController : MonoBehaviour{
    
    private float verticalInput;
    private float horizontalInput;
    private float speed = 0.3f;

    void Update(){
        ControllerPlayer();
    }
    private void ControllerPlayer(){
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -horizontalInput * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(verticalInput * speed, 0, 0);
        transform.position += transform.forward * speed / 20;
    }
}