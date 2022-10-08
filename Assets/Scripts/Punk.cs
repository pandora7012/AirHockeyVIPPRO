using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float constantSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // rb.velocity = constantSpeed  * (rb.velocity.normalized);

    }
}
