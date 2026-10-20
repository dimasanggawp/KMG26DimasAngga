using UnityEngine;

public class ExampleBranch : MonoBehaviour
{
    public int health = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Damage(10);
        Damage(10);
        Damage(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage(int damageAmount)
    {
        bool isHealthZero = health <= 0;

        if (isHealthZero)
        {
            Debug.Log("Player is dead.");
        }
        else
        {
            health -= damageAmount;
            Debug.Log("Player terkena damage. Health saat ini: " + health);
        }
    }
}
