using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //Jika tombol mouse kiri ditekan
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        //Vector3 spawnPosition = new Vector3(0, 0, 0); //Lokasi spawn di koordinat
        Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0); //Lokasi spawn di koordinat random
        
        //Parameter pertama adalah objek yang akan di spawn, parameter kedua adalah lokasi spawn, parameter ketiga adalah rotasi objek yang di spawn
        Instantiate(spawnObject, spawnPosition, transform.rotation);    
    }
}
