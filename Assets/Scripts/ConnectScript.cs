using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class ConnectScript : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField textInputField;

    public void OnButtonClick()
    {
        if (string.IsNullOrWhiteSpace(textInputField.text))
        {
            Debug.LogWarning("Player name is empty");
            return;
        }

        string playerName = textInputField.text.Trim();
        PlayerPrefs.SetString("PlayerName", playerName);
        PhotonNetwork.NickName = playerName;

        Debug.Log("Player name set to: " + playerName);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.LogWarning("No random room available, creating a new one.");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 4 });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom() called — attempting to load RoomScene");
        SceneManager.LoadScene("RoomScene");
    }


    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.LogWarning("Failed to join room: " + message);
    }
}
