using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cokkie_collector : MonoBehaviour
{
    private int cookiesCounter;
    
   private void OnTriggerEnter(Collider other)
    {
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
        if (other.gameObject.name.Equals("Capsule"))
        {
            GetComponent<MeshRenderer>().material = other.gameObject.GetComponent<MeshRenderer>().material;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name.Equals("Rotom"))
        {
            Debug.Log($"To win you have to collect all the coockies, you have {cookiesCounter}, and there are {41 - cookiesCounter} cookies left");
        }
    }

  

}
