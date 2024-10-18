using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonClicker : MonoBehaviour
{
    UIDocument buttonDocument;
    Button uiButton;
    void OnEnable()
    {
        buttonDocument = GetComponent<UIDocument>();

        if(buttonDocument == null)
        {
            Debug.LogError("No button document found");
        }

        uiButton = buttonDocument.rootVisualElement.Q("TestButton") as Button;

        if(uiButton != null)
        {
            Debug.Log("BUTTON FOUND");
        }

        uiButton.RegisterCallback<ClickEvent>(OnButtonClick);
    }
    ///Allows something to happen when the button is clicked
    public void OnButtonClick(ClickEvent evt)
    {
        SceneManager.LoadScene("MainScene");
    }
}
