using UnityEngine;

public class MultipleTables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int numero = 1; numero <= 10; numero++)
        {
            for (int i = 1; i <= 10; i++)
            {
                Debug.Log(numero + " x " + i + " = " + (numero * i));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}    
