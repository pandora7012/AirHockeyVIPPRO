using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUI : MonoBehaviour
{
    [SerializeField] private GameObject clientUI;
    [SerializeField] private GameObject serverUI;


    public void OnEnable()
    {
        clientUI.SetActive(false);
        serverUI.SetActive(false);
        
    }


    public void OnBackBT()
    {
        clientUI.SetActive(false);
        serverUI.SetActive(false);
    }

    public void OnJoinButton()
    {
    }

    public void OnServerBT()
    {
        clientUI.SetActive(false);
        serverUI.SetActive(true);
        Info.Instance.type = Info.InternetType.Host;
        SceneManager.LoadScene(1);
    }

    public void OnClientBT()
    {
        clientUI.SetActive(true);
        serverUI.SetActive(false);
    }
}