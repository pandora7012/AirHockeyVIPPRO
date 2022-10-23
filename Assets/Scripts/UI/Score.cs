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
        UpdateScore();
    }
    public void UpdateScore() {
        scoreGreen.text = GameManager.Instance.GetRedPoint().ToString();
        scoreRed.text = GameManager.Instance.GetGreenPoint().ToString();
    }
}
