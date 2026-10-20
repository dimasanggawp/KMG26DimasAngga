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
    
}
