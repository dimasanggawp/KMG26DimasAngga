using UnityEngine;

public struct Item
{
    public string id;
    public string name;
    public int quantity;

    //Constructur untuk struct Item
    public Item(string id, string name, int quantity)
    {
        this.id = id;
        this.name = name;
        this.quantity = quantity;
    }
   
}
