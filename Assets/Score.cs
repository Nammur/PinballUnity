using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int pontos;
    public Text scoreText;

    void Start()
    {
        pontos = 0;
    }

   public void Update()
    {
        scoreText.text = pontos.ToString() + " PONTOS";
    }
}
