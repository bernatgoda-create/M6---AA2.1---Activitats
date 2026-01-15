using UnityEngine;

public class Randomnumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float numbers = Random.Range(-10f, 10f);
        Debug.Log(numbers);
    }
}
