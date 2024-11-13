using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFruitScript : MonoBehaviour
{

    

    
    public int Fruits; /// storing collected fruits
    public GameObject TriggerObj;
    // Start is called before the first frame update
    void Start()
    {
        TriggerObj.gameObject.SetActive(false);
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
            TriggerObj.gameObject.SetActive(true);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
       
    }
}
