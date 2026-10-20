using UnityEngine;

public class ExampleDataStructure : MonoBehaviour
{
    public Player player1 = new Player("Dimas", 100, 10); 
    public Player player2 = new Player("Angga", 80, 20);
    
    [SerializeField]
    private Enemy slime = new Enemy("Slime", 10);

    private string[] arrayNames;
    public Vector3[] arrayVector3;
    public Enemy[] arrayEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

        arrayNames = new string[3];
        arrayNames[0] = "Dimas";
        arrayNames[1] = "Angga";
        arrayNames[2] = "Budi";

        for (int i = 0; i < arrayNames.Length; i++)
        {
            Debug.Log("Array Name: " + arrayNames[i]);
        }

        for (int i = 0; i < arrayEnemy.Length; i++)
        {
            Debug.Log("Array Enemy Name: " + arrayEnemy[i].name);
        }

    }
}
