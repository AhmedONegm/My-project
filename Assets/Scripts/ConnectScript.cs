using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement; // Add this if you are using TextMeshPro components

public class ConnectScript : MonoBehaviour
{
    // Declare a reference to a TMP_InputField (or TMP_Text if you meant a label)
    [SerializeField] TMP_InputField textInputField;

    public void OnButtonClick()
    {
        if (textInputField.text == null){
            Debug.LogWarning("Player name is null");
            return;
        }
        else
        {
            PlayerPrefs.SetString("PlayerName", textInputField.text);
            Debug.Log("Player name set to: " + textInputField.text);
            SceneManager.LoadScene("RoomScene");
        }
    }
}
