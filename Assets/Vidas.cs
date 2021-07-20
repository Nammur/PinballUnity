using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public BolaScript bola;
    public Text vidasText;


    public void Update()
    {
        if (bola.fimDeJogo)
        {
            vidasText.text = "FIM DE JOGO!";
        }
        else
        {
            vidasText.text = bola.bolas.ToString() + " BOLAS RESTANTES";
        }
    }
}
