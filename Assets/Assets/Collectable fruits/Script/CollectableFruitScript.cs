using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFruitScript : MonoBehaviour
{

    public int Fruits; /// storing collected fruits
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
