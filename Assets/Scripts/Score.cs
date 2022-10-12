using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreGreen;
    [SerializeField] TextMeshPro scoreRed;
    // Start is called before the first frame update
    void Start()
    {
        updateScore();
    }
    private void updateScore() {
        GameManager gameManager = new GameManager();
        scoreGreen.text = gameManager.GetRedPoint().ToString();
        scoreRed.text = gameManager.GetGreenPoint().ToString();
    }
}
