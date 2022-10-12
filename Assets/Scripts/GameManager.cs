using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Punk punk;
    public static GameObject save;
    private int redPoint; //Diem ben do
    private int greenPoint; //Diem ben xanh

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

    public static void PauseGame(bool pauseGame)
    {
        if (pauseGame)
        {
            //dung lai
            //game.Enabled=false;
        }
        else
        {
            //tiep tuc
            //game.Enabled=true;
        }
    }
}

