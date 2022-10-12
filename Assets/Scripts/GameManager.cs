using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Punk punk;
    public static GameObject save;
    public static int redPoint;
    public static int greenPoint;

    public static void SetDiem(bool GhiBan) //True: Do ghi ban; False: Xanh ghi ban
    {
        if (GhiBan)
        {
            redPoint++;
        }
        else
        {
            greenPoint++;
        }
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

