using UnityEngine;

public class ExampleVariable : MonoBehaviour
{
    public int number = 15;
    public string name = "Dimas Angga";
    public bool isActive = true;

    [SerializeField]
    private float speed = 10.5f;
    public Vector2 coordinate2D = new Vector2(10, 15);
    public Vector3 coordinate3D = new Vector3(10, 15, 20);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        number = 10;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
