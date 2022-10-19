using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool isRedHome;
    [SerializeField] private bool isBlueHome;


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Punk"))
        {
            GoalIn();
            if (GameManager.Instance.GetRedPoint() < 10 && GameManager.Instance.GetGreenPoint() < 10)
                GameManager.Instance.punk.OnReset();
        }
    }

    private void GoalIn()
    {
        GameManager.Instance.punk.gameObject.SetActive(false);
        if (isRedHome)
        {
            GameManager.Instance.RedScored();
        }
        else
        {
            GameManager.Instance.GreenScored();
        }

        if (GameManager.Instance.GetRedPoint() == 10 || GameManager.Instance.GetGreenPoint() == 10)
        {
            GameManager.Instance.WinGame(isRedHome);
        }
    }
}