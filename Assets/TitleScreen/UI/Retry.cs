using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Retry : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
