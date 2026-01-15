using UnityEngine;

public class Calculadora : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        float numberA = Random.Range(1f, 10f);
        float numberB = Random.Range(1f, 10f);

        char operador = ElegirOperador();
        float resultado = CalcularOperacion(numberA, numberB, operador);

        Debug.Log($"A: {numberA} B: {numberB} operacion: {operador}");
        Debug.Log($"resultado = {resultado}");
        

        
    }

    char ElegirOperador()
    {
        char[] ops = { '+', '-', '*', '/', '%' };
        return ops[Random.Range(0, ops.Length)];
    }

    float CalcularOperacion(float numberA, float numberB, char op)
    {
        switch (op)
        {
            case '+':
                return numberA + numberB;
            case '-':
                return numberA - numberB;
            case '*':
                return numberA * numberB;
            case '/':
                return numberB != 0 ? numberA / numberB : 0;
            case '%':
                return numberB != 0 ? numberA % numberB : 0;
            default:
                return 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
