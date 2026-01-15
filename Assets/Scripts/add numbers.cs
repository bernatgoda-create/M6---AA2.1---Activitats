using UnityEngine;

public class addnumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float numeroA = Random.Range(0f, 10f);
        float numeroB = Random.Range(0f, 10f);

        float suma = numeroA + numeroB;

        Debug.Log($"nemeroA: {numeroA}");
        Debug.Log($"nemeroB: {numeroB}");
        Debug.Log($"suma= {suma}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
