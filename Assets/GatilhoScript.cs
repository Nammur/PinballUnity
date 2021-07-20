using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatilhoScript : MonoBehaviour
{
    float power;
    public float maxPower = 100f;
    public float minPower = 0f;
    public Slider powerSlider;
    List<Rigidbody> ballList;
    bool bolaPronta;

    void Start()
    {
        powerSlider.minValue = minPower;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
    }

   void Update()
    {
        if (bolaPronta)
        {
            powerSlider.gameObject.SetActive(true);
        }
        else
        {
            powerSlider.gameObject.SetActive(false);
        }

        powerSlider.value = power;
        if(ballList.Count > 0)
        {
            bolaPronta = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if(power <= maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach(Rigidbody ball in ballList)
                {
                    ball.AddForce(power * Vector3.forward);
                }
            }
        }
        else
        {
            bolaPronta = false;
            power = minPower;
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Bola"))
        {
            ballList.Add(c.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.CompareTag("Bola"))
        {
            ballList.Remove(c.gameObject.GetComponent<Rigidbody>());
            power = minPower;
        }
    }
}
