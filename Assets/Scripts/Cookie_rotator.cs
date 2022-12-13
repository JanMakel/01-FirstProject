using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_rotator : MonoBehaviour
{
    //Variable of the spepd rotation of the cookies (and the cube at the end)
    public float speed = 60f;

    private void Update()
    {
        //Infinite rotation of the coockies and the cube
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
