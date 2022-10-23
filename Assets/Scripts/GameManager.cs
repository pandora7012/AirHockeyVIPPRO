using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Punk punk;
    private int redPoint; //Diem ben do
    private int greenPoint; //Diem ben xanh
    public bool pauseGame;
<<<<<<< Updated upstream
    public Score score; 

=======
    public Score score;
    public WingameUI winGameUI;
    
>>>>>>> Stashed changes
    void Start()
    {
        redPoint = 0;
        greenPoint = 0;
    }

    public void SetPoint(bool GhiBan) //True: Red ghi ban; False: Green ghi ban
    {
        if (GhiBan)
        {
            redPoint++; //Cong diem cho red
        }
        else
        {
            greenPoint++; //Cong diem cho green
        }
    }

    public void RedScored()
    {
        redPoint++;
        score.UpdateScore();
    }

    public void GreenScored()
    {
        greenPoint++;
        score.UpdateScore();
    }

    public int GetRedPoint()
    {
        return redPoint; //Tra ve diem ben do
    }

    public int GetGreenPoint()
    {
        return greenPoint; //Tra ve diem ben xanh
    }
<<<<<<< Updated upstream
}

=======

    public void WinGame(bool isRed)
    {
        winGameUI.OnShow(isRed);
    }
}
>>>>>>> Stashed changes
