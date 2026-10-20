using UnityEngine;

public class LogicalOperator : MonoBehaviour
{

    public bool logic1 = true;
    public bool logic2 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool andResult = logic1 && logic2;
        bool orResult = logic1 || logic2;
        bool notResult = !logic1;
        Debug.Log("Hasil AND: " + andResult);
        Debug.Log("Hasil OR: " + orResult);
        Debug.Log("Hasil NOT: " + notResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
