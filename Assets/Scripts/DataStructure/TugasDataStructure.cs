using UnityEngine;
using System.Collections.Generic;

public class TugasDataStructure : MonoBehaviour
{
    //Declare List of Weapon nya di sini, saya kasih nama weapons, belum ada isinya
    public List<Weapon> weapons = new List<Weapon>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Kuy List Weapon nya diisi dulu, sesuai dengan soal. Kalo kosong ntar jadi wapres
        weapons.Add(new Weapon(1, "Basic Sword", 10));
        weapons.Add(new Weapon(2, "Spear", 40));
        weapons.Add(new Weapon(3, "Staff", 70));

        //Kita coba cari nama yang ada
        Debug.Log(Weapon.IsWeaponExist(weapons, "Spear")); // Harusnya true
        //Kita coba cari nama yang gaada, jangan kayak wapres : ada tapi gaada
        Debug.Log(Weapon.IsWeaponExist(weapons, "Bow")); // Harusnya false

        //Kita coba ambil semua weapon yang damage nya lebih dari 30
        List<Weapon> strongWeapons = Weapon.GetWeaponsByDamage(weapons, 30);
        for(int i = 0; i < strongWeapons.Count; i++)
        {
            Debug.Log(strongWeapons[i].name + " punya damage " + strongWeapons[i].damage);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
