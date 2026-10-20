using UnityEngine;

public class ExampleDataStructure : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player1 = new Player("Dimas", 100, 10); 

        Player player2 = new Player("Angga", 80, 20);

        Debug.Log("Player Name: " + player1.name);
        Debug.Log("Player Health: " + player1.health);
        Debug.Log("Player Attack: " + player1.attack);

        Debug.Log("Player Name: " + player2.name);
        Debug.Log("Player Health: " + player2.health);
        Debug.Log("Player Attack: " + player2.attack);
    }
}
