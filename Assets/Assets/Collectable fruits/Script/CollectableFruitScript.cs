using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFruitScript : MonoBehaviour
{

    

    
    public int Fruits; /// storing collected fruits
    public GameObject SecondDoor;
    public GameObject FirstDoor;
    // Start is called before the first frame update
    void Start()
    {
        SecondDoor.gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Fruit")
        {
            Debug.Log("Fruit is collected!");
            Fruits = Fruits + 1;
            ScoreManager.instance.AddFruit();
            Destroy(Col.gameObject);
           
        }

        if(Fruits >= 14)
        {
            SecondDoor.gameObject.SetActive(true);
            FirstDoor.gameObject.SetActive(false);
        }
        else
        {
            FirstDoor.gameObject.SetActive(true);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
       
    }
}
