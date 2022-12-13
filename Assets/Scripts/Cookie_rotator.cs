using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_rotator : MonoBehaviour
{
    public float speed = 60f;

    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
