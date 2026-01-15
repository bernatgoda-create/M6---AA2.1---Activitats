using UnityEngine;

public class multitable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numero = Random.Range(0, 11);
        float op0 = numero * 0;
        float op1 = numero * 1;
        float op2 = numero * 2;
        float op3 = numero * 3;
        float op4 = numero * 4;
        float op5 = numero * 5;
        float op6 = numero * 6;
        float op7 = numero * 7;
        float op8 = numero * 8;
        float op9 = numero * 9;
        float op10 = numero * 10;

        Debug.Log($"el numero a multiplicar es {numero}");
        Debug.Log($"{numero} * {0} = " + op0);
        Debug.Log($"{numero} * {1} = " + op1);
        Debug.Log($"{numero} * {2} = " + op2);
        Debug.Log($"{numero} * {3} = " + op3);
        Debug.Log($"{numero} * {4} = " + op4);
        Debug.Log($"{numero} * {5} = " + op5);
        Debug.Log($"{numero} * {6} = " + op6);
        Debug.Log($"{numero} * {7} = " + op7);
        Debug.Log($"{numero} * {8} = " + op8);
        Debug.Log($"{numero} * {9} = " + op9);
        Debug.Log($"{numero} * {10} = " + op10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
