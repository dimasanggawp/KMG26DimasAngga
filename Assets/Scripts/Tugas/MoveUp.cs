using UnityEngine;

//Dijadikan kelas sendiri supaya ketika klik baru ditekan,
//GameObject lama tetap bisa berjalan, jika tidak maka
//GameObject lama akan berhenti dan GameObject baru saja yang bergerak
public class MoveUp : MonoBehaviour
{
    public float movementSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }
}
