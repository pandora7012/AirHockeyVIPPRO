using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static Punk punk;
    public static GameObject save;
    private int redPoint; //Diem ben do
    private int greenPoint; //Diem ben xanh
    public bool pauseGame;

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

    public int GetRedPoint()
    {
        return redPoint; //Tra ve diem ben do
    }

    public int GetGreenPoint()
    {
        return greenPoint; //Tra ve diem ben xanh
    }
}

