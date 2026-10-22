using UnityEngine;

public class DestroyManager : MonoBehaviour
{

    public GameObject destroyObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)) //Jika tombol mouse kiri ditekan
        {
            GetCursorPosition();
            DetectObject();
            //DestroyObject();
        }
        
    }

    //Mencari posisi dimana klik mouse berada
    void GetCursorPosition()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Mengubah posisi klik mouse dari layar ke koordinat dunia
        cursorPosition.z = 0; //Mengatur posisi z menjadi 0 agar objek yang di spawn berada di depan kamera
        Debug.Log("Cursor Position: " + cursorPosition); //Menampilkan posisi klik mouse di console
    }

    void DestroyObject()
    {
        Destroy(destroyObject);
        Debug.Log("Object Destroyed: " + destroyObject.name); //Menampilkan nama objek yang di destroy di console
    }

    void DetectObject()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Mengubah posisi klik mouse dari layar ke koordinat dunia
        cursorPosition.z = 0; //Mengatur posisi z menjadi 0 agar objek yang
        RaycastHit2D hit = Physics2D.Raycast(cursorPosition, Vector2.zero); //Membuat raycast dari posisi klik mouse ke arah z

        if(hit.collider != null) //Jika raycast mengenai collider
        {
            destroyObject = hit.collider.gameObject; //Menyimpan objek yang di deteksi ke dalam variabel destroyObject
            DestroyObject(); //Memanggil fungsi DestroyObject untuk menghancurkan objek yang di deteksi
            Debug.Log("Object Detected: " + hit.collider.name); //Menampilkan nama objek yang di deteksi di console
        }
    }
}
