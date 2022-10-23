using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WingameUI : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI _winText;
    
    public void OnShow(bool redWin)
    {
        gameObject.SetActive(true);
        _winText.text = !redWin ? "Red Win" : "Green Win";
    }
    

}
