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
            //I have two options of game over, they get the same but one destroys the game object and the other one get the player to the initial position of the player

            //Destroy(gameObject);
            //Time.timeScale = 0;
            transform.position = initialPos;
            Debug.Log($"You lose. GAME OVER");
        }

    }
}
