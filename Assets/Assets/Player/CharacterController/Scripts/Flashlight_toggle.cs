using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_toggle : MonoBehaviour
   
{
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.enabled = !light.enabled;
        }
    }
}
