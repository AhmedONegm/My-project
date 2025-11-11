using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI RoomText;
    
    void Start()
    {
        RoomText = GameObject.Find("RoomText").GetComponent<TMPro.TextMeshProUGUI>();
        RoomText.text = "Connected to Room: " + PlayerPrefs.GetString("PlayerName");
        Debug.Log(RoomText.text + " Connected to Room");
    }


}
