using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dissapear : MonoBehaviour
{
    public GameObject GameOverUI;
  public void whenButtonClicked()
  {
     gameObject.SetActive(!gameObject.activeInHierarchy);
  }
}
