using UnityEngine;

public class Average : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float numberA = Random.Range(0f, 10f);
        float numberB = Random.Range(0f, 10f);
        float numberC = Random.Range(0f, 10f);

        float suma = numberA + numberB + numberC /3;
        Debug.Log($"A: {numberA}, B: {numberB}, C: {numberC}");
        Debug.Log($"Average = {suma}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
