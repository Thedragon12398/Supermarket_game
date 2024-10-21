using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    
    [SerializeField]
    private GameObject gameOverMenu;
   public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            gameOverMenu.SetActive(true);
        }
    }
}
