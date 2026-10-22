using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text TittleText;
    public List<string> listNama;
    public TMP_Text TextNama;
    public int indexNama;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButton()
    {
        TittleText.text = "Ini judul";
        Debug.Log("Tombol ditekan");
    }

    public void UbahKanan()
    {
        TittleText.text = "Kanan";
    }

    public void UbahKiri()
    {
        TittleText.text = "Kiri";
    }

    public void NextNama()
    {
        indexNama++;
        
        if(indexNama >= listNama.Count)
        {
            indexNama = 0;
        }

        TextNama.text = listNama[indexNama];
    }

    public void PrevNama()
    {
        indexNama--;

        if(indexNama < 0)
        {
            indexNama = listNama.Count - 1;
        }

        TextNama.text = listNama[indexNama];
    }

}
