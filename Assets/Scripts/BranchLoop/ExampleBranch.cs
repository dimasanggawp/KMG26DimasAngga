using UnityEngine;

public class ExampleBranch : MonoBehaviour
{
    public int health = 120;
    public int score; //80-100 = A, 70-79 = B, 60-69 = C, 50-59 = D, <50 = E
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Damage(10);
        Damage(10);
        Damage(10);
        CheckScore(score);

        for (int i = 0; i < 3; i++)
        {
            Damage(10);
            Debug.Log("Health saat ini: " + health);
        }

        while (health > 0)
        {
            Damage(10);
            Debug.Log("Health saat ini: " + health);
        }
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

    void CheckScore(int score)
    {
        if (score >= 80)
        {
            Debug.Log("Grade: A");
        }
        else if (score >= 70)
        {
            Debug.Log("Grade: B");
        }
        else if (score >= 60)
        {
            Debug.Log("Grade: C");
        }
        else if (score >= 50)
        {
            Debug.Log("Grade: D");
        }
        else
        {
            Debug.Log("Grade: E");
        }
    }
}
