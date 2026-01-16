using UnityEngine;

public class PPT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float numeroA = Random.Range(1,4);
        float numeroB = Random.Range(1, 4);

        //1 es piedra
        //2 es papel
        //3 es tijera

        if (numeroA == 1 & numeroB == 2)
        {
            Debug.Log("jugador A usa piedra");
            Debug.Log("jugador B usa papel");
            Debug.Log("jugador B gana");
        }
        if (numeroA == 2 & numeroB == 3)
        {
            Debug.Log("jugador A usa papel");
            Debug.Log("jugador B usa tijera");
            Debug.Log("jugador B gana");
        }
        if (numeroA == 3 & numeroB == 1)
        {
            Debug.Log("jugador A usa tijera");
            Debug.Log("jugador B usa piedra");
            Debug.Log("jugador B gana");
        }
        if (numeroA == 3 & numeroB == 2)
        {
            Debug.Log("jugador A usa tijera");
            Debug.Log("jugador B usa papel");
            Debug.Log("jugador A gana");
        }
        if (numeroA == 2 & numeroB == 1)
        {
            Debug.Log("jugador A usa papel");
            Debug.Log("jugador B usa piedra");
            Debug.Log("jugador A gana");
        }
        if (numeroA == 1 & numeroB == 3)
        {
            Debug.Log("jugador A usa piedra");
            Debug.Log("jugador B usa tijera");
            Debug.Log("jugador A gana");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
