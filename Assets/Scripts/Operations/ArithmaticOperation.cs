using UnityEngine;

public class ArithmeticOperation : MonoBehaviour
{
    public int number1 = 12;
    public int number2 = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int plusResult = number1 + number2;
        string firstName = "Dimas";
        string lastName = "Angga";
        Debug.Log("Hasil: " + plusResult);
        Debug.Log("Nama Lengkap: " + firstName + " " + lastName + " " + number1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
