using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    //Mulitple Variables to get the speed of the player, the rotation of the camera and both inputs horizontal and vertical
    public float speed = 10f;
    private float turnspeed = 5f;
    private float horizontalInput;
    private float verticalInput;

    private void Update()
    {
        //Here are the inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Here are the operations of rotation and translation of the player
        transform.Translate(Vector3.forward * turnspeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, speed * Time.deltaTime * horizontalInput);
    }

}
