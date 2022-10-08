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
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                if (mousePos.x >= boundX.x && mousePos.x <= boundX.y && mousePos.y >= boundY.x && mousePos.y <= boundY.y)
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                rb.MovePosition(mousePos);
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }
}