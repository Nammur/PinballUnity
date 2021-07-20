using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaScript : MonoBehaviour
{
    public int bolas;
    Transform bola;
    Rigidbody fisicaBola;
    public bool fimDeJogo;

    void Start()
    {
        bola = GetComponent<Transform>();
        fisicaBola = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Buraco")
        {
            if (bolas > 0)
            {
                bolas += -1;
                bola.position = new Vector3(3.78f, 0.09f, 0.72f);
                fisicaBola.velocity = Vector3.zero;
            }
            else
            {
                bola.position = new Vector3(100f, 100f, 100f);
                fimDeJogo = true;
            }
        }
        else if (col.gameObject.tag == "3PONTOS")
        {
            fisicaBola.AddForce(300f * Vector3.back);
        }

    }


}
