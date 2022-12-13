using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float speed = 10f;
    private float turnspeed = 5f;
    private float horizontalInput;
    private float verticalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * turnspeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, speed * Time.deltaTime * horizontalInput);
    }

}
