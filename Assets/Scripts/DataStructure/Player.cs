using UnityEngine;

[System.Serializable]
public class Player 
{
    public string name;
    public int health;
    private int attack;

    //Constructor untuk menginisialisasi nilai default dari atribut Player
    public Player(string name, int health, int attack)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
    }

    public void Info()
    {
        Debug.Log("Player Name: " + name);
        Debug.Log("Player Health: " + health);
        Debug.Log("Player Attack: " + attack);
    }

    public void AttackEnemy(Enemy enemy)
    {
        enemy.TakeDamage(attack);
    }
    
}
