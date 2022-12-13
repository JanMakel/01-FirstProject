using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cokkie_collector : MonoBehaviour
{
    //Variable that stores the number of coockies collected
    private int cookiesCounter;
    
   private void OnTriggerEnter(Collider other)
    {
        //When a coockie collides with the player the cookie will disapear and add one to counter
        if (other.gameObject.name.Equals("Cookie"))
        {
            Destroy(other.gameObject);
            cookiesCounter++;
            if (cookiesCounter == 41)
            {
                Debug.Log($"You WIN!");
                Time.timeScale = 0;
            }
            
        }
        //The capsule in the map will change the material of the player from red to blue when collides
        if (other.gameObject.name.Equals("Capsule"))
        {
            GetComponent<MeshRenderer>().material = other.gameObject.GetComponent<MeshRenderer>().material;
            Destroy(other.gameObject);
           
        }
        //When the player collides with the final purple cube the player will get a message that will say how many coockies he have and how many cookies are left to win the game
        if (other.gameObject.name.Equals("Rotom"))
        {
            Debug.Log($"To win you have to collect all the coockies, you have {cookiesCounter}, and there are {41 - cookiesCounter} cookies left");
        }
    }

  

}
