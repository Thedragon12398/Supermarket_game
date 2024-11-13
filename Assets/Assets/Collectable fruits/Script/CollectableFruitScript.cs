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
            ///Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
           
        }

        if(Fruits >= 1)
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
