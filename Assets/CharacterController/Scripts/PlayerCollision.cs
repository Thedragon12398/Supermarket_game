using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
   private void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Enemy")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Death Scene");
        }

        if(col.transform.tag == "Way out")
        {
            Debug.Log("You win");
            SceneManager.LoadScene("You win");
        }
    }

   
}
