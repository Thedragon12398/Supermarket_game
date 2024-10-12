using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour
{
    public enum SpeedBoost { Speed }
    public SpeedBoost speedboost;

    public float AmountToGive;

    private CharacterMovement Player;

    private void Awake()
    {
        Player = Object.FindFirstObjectByType<CharacterMovement>();
    }

    private void OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            switch (speedboost)
            {
                case SpeedBoost.Speed:
                    Player.walkSpeed += AmountToGive;
                    break;
                default:
                    break;
            }

            Destroy(gameObject);
        }
    }

}
