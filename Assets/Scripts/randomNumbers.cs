using UnityEngine;

public class randomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            int n = Random.Range(1, 101);
            Debug.Log(n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
