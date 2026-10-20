using UnityEngine;

public class ExampleDataStructure : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player1 = new Player(); 
        player1.name = "Dimas Angga";
        player1.health = 100;
        player1.attack = 10;

        Debug.Log("Player Name: " + player1.name);
        Debug.Log("Player Health: " + player1.health);
        Debug.Log("Player Attack: " + player1.attack); 
    }
}
