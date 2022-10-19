using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float constantSpeed;
    public bool onPlay; //this is to check if the punk is on play or not

    public void OnReset()
    {
        GameObject o;
        (o = gameObject).SetActive(true);
        o.transform.position = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("GoalRed") && !col.gameObject.CompareTag("GoalGreen")) return;
        gameObject.SetActive(false);
    }
}