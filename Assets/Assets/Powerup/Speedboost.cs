using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour
{
    private void Start()
    {

    }

    public float multiplier = 20.0f;
    public Camera cameraFov;

    private void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
           
            CharacterMovement.runSpeed = multiplier;    
            Destroy(gameObject);
        }
    }





}
