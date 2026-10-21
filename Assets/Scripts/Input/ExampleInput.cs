using UnityEngine;

public class ExampleInput : MonoBehaviour
{
    public int health = 100;
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
            TakeDamage(10);
        }
        if (Input.GetMouseButtonDown(1)) //Mendeteksi klik kanan mouse
        {
            Debug.Log("Klik kanan ditekan");
            Heal(10);
        }
        // if (Input.GetMouseButtonUp(0)) //Mendeteksi klik kiri mouse dilepas
        // {
        //     Debug.Log("Klik kiri dilepas");
        // }
        // if (Input.GetMouseButtonDown(1)) //Mendeteksi klik kanan mouse
        // {
        //     Debug.Log("Klik kanan ditekan");
        // }
        // if (Input.GetMouseButtonDown(2)) //Mendeteksi klik tengah mouse
        // {
        //     Debug.Log("Klik tengah ditekan");
        // }
    }

    void TakeDamage(int damage)
    {
        if(health > 0)
        {
            health -= damage;
        }
        Debug.Log("Health: " + health);

        if (health <= 0)
        {
            Debug.Log("Player meninggoy");
        }
    }

    void Heal(int healAmount)
    {
        if(health < 100)
        {
            health += healAmount;
        }
        Debug.Log("Health: " + health);
    }
}
