using UnityEngine;

[System.Serializable]
public class Enemy
{
    public string name;
    public int health;

    //Constructor untuk menginisialisasi nilai default dari atribut Enemy
    public Enemy(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
