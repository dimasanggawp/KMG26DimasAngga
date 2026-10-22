using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotateSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateClockwise();
    }

    void RotateClockwise()
    {
        transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
    }
}
