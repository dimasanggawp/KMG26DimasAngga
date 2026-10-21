using UnityEngine;

public class ExampleInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mendeteksi klik kiri mouse
        {
            Debug.Log("Klik kiri ditekan");
        }
        if (Input.GetMouseButtonDown(1)) //Mendeteksi klik kanan mouse
        {
            Debug.Log("Klik kanan ditekan");
        }
        if (Input.GetMouseButtonDown(2)) //Mendeteksi klik tengah mouse
        {
            Debug.Log("Klik tengah ditekan");
        }
    }
}
