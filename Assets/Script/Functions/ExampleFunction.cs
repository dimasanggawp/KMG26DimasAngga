using UnityEngine;

public class ExampleFunction : MonoBehaviour
{
    public int health = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ContohFunction();
        AddHealth(20); // Menambahkan 20 ke health
        AddHealth(-10); // Mengurangi 10 dari health
        AddHealth(50); // Menambahkan 50 ke health
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ContohFunction()
    {
        // Isi dari fungsi contoh
        Debug.Log("Ini adalah contoh fungsi");
    }

    void AddHealth(int amount)
    {
        // Contoh fungsi untuk menambahkan health
        Debug.Log("Health awal: " + health);
        health += amount;
        Debug.Log("Health setelah ditambahkan: " + health);
    }
}
