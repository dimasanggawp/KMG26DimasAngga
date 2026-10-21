using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Weapon
{
    public int id;
    public string name;
    public int damage;

    // Constructornya ada di sini guys
    public Weapon(int id, string name, int damage)
    {
        this.id = id;
        this.name = name;
        this.damage = damage;
    }

    public static bool IsWeaponExist(List<Weapon> weapons, string weaponName)
    {
        return weapons.Exists(w => w.name == weaponName);
    }

    public static List<Weapon> GetWeaponsByDamage(List<Weapon> weapons, int minDamage)
    {
        return weapons.FindAll(w => w.damage >= minDamage);
    }
}
