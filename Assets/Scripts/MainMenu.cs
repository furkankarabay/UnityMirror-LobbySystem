using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private NetworkManagerLobby networkManager = null;

    [Header("UI")]
    [SerializeField] private GameObject landingPanel = null;

    public void HostLobby()
    {
        networkManager.StartHost();
        landingPanel.SetActive(false);
    }
}
