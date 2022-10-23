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
<<<<<<< Updated upstream
    
    void FixedUpdate()
=======

    void Update()
>>>>>>> Stashed changes
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
<<<<<<< Updated upstream
        if (!(mousePos.x  < boundX.x || mousePos.x > boundX.y || mousePos.y < boundY.x || mousePos.y > boundY.y))
        {
           /* if (Input.GetMouseButton(0))
            {*/
                rb.MovePosition(mousePos);
            /*}*/
        }
        else
=======
        if (mousePos.x < boundX.x || mousePos.x > boundX.y || mousePos.y < boundY.x || mousePos.y > boundY.y)
            return;

        if (Input.GetMouseButton(0))
>>>>>>> Stashed changes
        {
            if ((mousePos.x < boundX.x &&  mousePos.y < boundY.x) || (mousePos.x < boundX.x && mousePos.y > boundY.y)
                || (mousePos.x > boundX.y && mousePos.y < boundY.x) || (mousePos.x > boundX.y && mousePos.y > boundY.y))
            {
                return;
            }
            if(mousePos.x < boundX.x || mousePos.x > boundX.y)
            {
                var vector2 = rb.position;
                vector2.y = mousePos.y;
                rb.MovePosition(vector2);
            }
            if (mousePos.y < boundY.x || mousePos.y > boundY.y)
            {
                var vector2 = rb.position;
                vector2.x = mousePos.x;
                rb.MovePosition(vector2);
            }
            
        }
<<<<<<< Updated upstream
        
        
        
=======
>>>>>>> Stashed changes
    }
}