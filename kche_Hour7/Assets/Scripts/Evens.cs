using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Loop through even numbers from 22 to 100
        for (int i = 22; i <= 100; i += 2)
        {
            // Output the current even number to the Unity console
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add update logic here if needed
    }
}