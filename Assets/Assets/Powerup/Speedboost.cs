using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour
{
    public float multiplier = 1.5f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            .Speed *= 1.5f;
            Destroy(gameObject);
        }
    }
}
