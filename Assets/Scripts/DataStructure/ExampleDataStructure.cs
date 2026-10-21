using UnityEngine;
using System.Collections.Generic;

public class ExampleDataStructure : MonoBehaviour
{
    public Player player1 = new Player("Dimas", 100, 10); 
    public Player player2 = new Player("Angga", 80, 20);
    
    [SerializeField]
    private Enemy slime = new Enemy("Slime", 10);

    private string[] arrayNames;
    public Vector3[] arrayVector3;
    public Enemy[] arrayEnemy;
    public List<Item> listItems;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ContohStruct();
        //ContohList();
        ContohListItem();

        //Debug.Log("Player Name: " + player1.name);
        //Debug.Log("Player Health: " + player1.health);
        //Debug.Log("Player Attack: " + player1.attack);

        //Debug.Log("Player Name: " + player2.name);
        //Debug.Log("Player Health: " + player2.health);
        //Debug.Log("Player Attack: " + player2.attack);
        
        // player1.Info();
        // player2.Info();

        //slime.TakeDamage(5);
        // player2.AttackEnemy(slime);
        // Debug.Log("Enemy Name: " + slime.name);
        // Debug.Log("Enemy Health: " + slime.health);

        // arrayNames = new string[3];
        // arrayNames[0] = "Dimas";
        // arrayNames[1] = "Angga";
        // arrayNames[2] = "Budi";

        // for (int i = 0; i < arrayNames.Length; i++)
        // {
        //     Debug.Log("Array Name: " + arrayNames[i]);
        // }

        // for (int i = 0; i < arrayEnemy.Length; i++)
        // {
        //     Debug.Log("Array Enemy Name: " + arrayEnemy[i].name);
        // }

    }

    Player Dimas;
    Item Sword;
    void ContohStruct()
    {
        Sword = new Item("001", "Excalibur Sword", 1);
        Debug.Log("Item ID: " + Sword.id);
        Debug.Log("Item Name: " + Sword.name);
        Debug.Log("Item Quantity: " + Sword.quantity);
    }

    void ContohList()
    {
        List<int> listNumbers = new List<int>();
        listNumbers.Add(1);
        listNumbers.Add(2);
        listNumbers.Add(3);

        Debug.Log("Elemen Pertama: " + listNumbers[0]);
        Debug.Log("Ukuran List: " + listNumbers.Count);

        listNumbers.RemoveAt(0);
        Debug.Log("Elemen Setelah Remove: " + listNumbers[0]);
        Debug.Log("Ukuran List Setelah Remove: " + listNumbers.Count);

        listNumbers.Remove(2);
        Debug.Log("Ukuran List Setelah Remove: " + listNumbers.Count);
    }

    void ContohListItem()
    {
        List<string> inventory = new List<string>();
        inventory.Add("Potion");
        inventory.Add("Sword");
        inventory.Add("Shield");

        bool hasPotion = inventory.Exists(item => item == "Potion");
        Debug.Log("Has Potion: " + hasPotion);

        Debug.Log("Apakah memiliki Rusty Sword: " + listItems.Exists(item => item.name == "Rusty Sword"));
    }
}
