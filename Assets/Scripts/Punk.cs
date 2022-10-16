using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float constantSpeed;


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("GoalRed"))
        {
            gameObject.SetActive(false);
        }
        else if (col.gameObject.CompareTag("GoalGreen"))
        {
            gameObject.SetActive(false);
        }
    }


}
