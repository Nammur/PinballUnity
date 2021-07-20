using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuacaoScript : MonoBehaviour
{
    public Score pontuacao;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bola") {
            if(tag == "1PONTO")
            {
                pontuacao.pontos++;
            }
            else if (tag == "2PONTOS")
            {
                pontuacao.pontos += 2;
            }
            else if (tag == "3PONTOS")
            {
                pontuacao.pontos += 3;
            }
        }

    }
}
