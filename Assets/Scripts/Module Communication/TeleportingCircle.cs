using UnityEngine;

public class TeleportingCircle : MonoBehaviour
{
    public Vector2 minPosition;
    public Vector2 maxPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Teleport();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teleport()
    {
        Vector3 newPosition = new Vector3(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y),
            0
        );
        transform.position = newPosition;
    }
}
