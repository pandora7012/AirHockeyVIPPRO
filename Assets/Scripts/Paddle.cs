using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    bool wasJustClicked = true;
    bool canMove;

    [SerializeField] private Vector2 boundX;
    [SerializeField] private Vector2 boundY;
    [SerializeField] private Rigidbody2D rb; 
    
    void Start()
    {
    }
    
    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x  < boundX.x || mousePos.x > boundX.y || mousePos.y < boundY.x || mousePos.y > boundY.y)
            return;
        
        if (Input.GetMouseButton(0))
        {
            rb.MovePosition(mousePos);
        }
        
    }
}