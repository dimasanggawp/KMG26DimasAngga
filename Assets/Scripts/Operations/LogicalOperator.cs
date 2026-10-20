using UnityEngine;

public class LogicalOperator : MonoBehaviour
{

    public bool logic1 = true;
    public bool logic2 = false;
    public int health = 100;
    public Vector2 position = new Vector2(10, 20);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isPlayerDead = health <= 0 || position.y < 0;
        bool andResult = logic1 && logic2;
        bool orResult = logic1 || logic2;
        bool notResult = !logic1;
        Debug.Log("Hasil AND: " + andResult);
        Debug.Log("Hasil OR: " + orResult);
        Debug.Log("Hasil NOT: " + notResult);
        Debug.Log("Apakah Player Mati: " + isPlayerDead);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
