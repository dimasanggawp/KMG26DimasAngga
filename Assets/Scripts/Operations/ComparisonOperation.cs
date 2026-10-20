using UnityEngine;

public class ComparisonOperation : MonoBehaviour
{
    public int number1 = 12;
    public int number2 = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isEqual = number1 == number2;
        bool isNotEqual = number1 != number2;
        bool isGreater = number1 > number2;
        bool isLess = number1 < number2;
        Debug.Log("Apakah sama: " + isEqual);
        Debug.Log("Apakah tidak sama: " + isNotEqual);
        Debug.Log("Apakah lebih besar: " + isGreater);
        Debug.Log("Apakah lebih kecil: " + isLess);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
