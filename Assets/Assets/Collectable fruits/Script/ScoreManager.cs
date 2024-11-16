using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    public Text FruitText;

    public int Fruit = 0;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        FruitText.text = Fruit.ToString() + "";
    }

    public void AddFruit()
    {
        Fruit += 1;
        FruitText.text = Fruit.ToString() + "";
    }
}
