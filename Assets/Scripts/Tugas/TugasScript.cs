using UnityEngine;

public class TugasScript : MonoBehaviour
{
    public GameObject prefabObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Menampung GameObject yang beru dibuat pada posisi cursor klik kiri ditekan
            GameObject spawned = SpawnObject(GetCursorPosition());
            //Menambahkan class MoveRight ke dalam component object yang baru dispawned
            spawned.AddComponent<MoveRight>();
        }

        if(Input.GetMouseButtonDown(1))
        {
            //Menampung GameObject yang beru dibuat pada posisi cursor klik kanan ditekan
            GameObject spawned = SpawnObject(GetCursorPosition());
            //Menambahkan class MoveUp ke dalam component object yang baru dispawned
            spawned.AddComponent<MoveUp>();
        }
        
    }

    public GameObject SpawnObject(Vector3 spawnPosition)
    {   
        return Instantiate(prefabObject, spawnPosition, transform.rotation);
    }

    //Mencari ijazah Wapres, eh maksudnya mencari dimana posisi cursor saat diklik
    public Vector3 GetCursorPosition()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = 0;
        return cursorPosition;
    }
}
