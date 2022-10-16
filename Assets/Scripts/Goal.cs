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
            Debug.Log("Goal");
        }
    }

    private void GoalIn()
    {
        if (isRedHome)
        {
            GameManager.Instance.RedScored();
        }
        else
            GameManager.Instance.GreenScored();
    }
}