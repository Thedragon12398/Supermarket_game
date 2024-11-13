using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public Animation DoorAni;

    public void OnTriggerEnter(Collider other)
    {
        DoorAni.Play();
    }
}
