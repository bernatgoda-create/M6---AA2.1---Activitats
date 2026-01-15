using UnityEngine;

public class RandomOperations : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float numberA = Random.value;
        float numberB = Random.value;
        float operation = Random.Range(0, 5);

        if (operation == 0) {
            float resultado = numberA + numberB;
            Debug.Log($"A: {numberA} B: {numberB} operation: +");
            Debug.Log(resultado);
        }
        if (operation == 1)
        {
            float resultado = numberA - numberB;
            Debug.Log($"A: {numberA} B: {numberB} operation: -");
            Debug.Log(resultado);
        }
        if (operation == 2) {
            float resultado = numberA * numberB;
            Debug.Log($"A: {numberA} B: {numberB} operation: *");
            Debug.Log(resultado);
        }
        if (operation == 3) {
            float resultado = numberA / numberB;
            Debug.Log($"A: {numberA} B: {numberB} operation: /");
            Debug.Log(resultado);
        }
        if (operation == 4) {
            float resultado = numberA % numberB;
            Debug.Log($"A: {numberA} B: {numberB} operation: %");
            Debug.Log(resultado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
