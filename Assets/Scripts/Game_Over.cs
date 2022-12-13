using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    private Vector3 initialPos = new Vector3(-4.33f, 1.87f, -35.64f);
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Laser"))
        {
            //Destroy(gameObject);
            //Time.timeScale = 0;
            transform.position = initialPos;
            Debug.Log($"You lose. GAME OVER");
        }

    }
}
