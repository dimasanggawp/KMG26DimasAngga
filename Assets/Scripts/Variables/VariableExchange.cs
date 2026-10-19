using UnityEngine;

public class VariableExchange : MonoBehaviour
{
    public int number1 = 10;
    public int number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Sebelum ditukar : \n number1 = {number1} \n number2 = {number2} \n");

        //Proses penukaran variable number1 dan number2
        number1 = number1 + number2 - (number2 = number1);
        
        Debug.Log($"Setelah ditukar : \n number1 = {number1} \n number2 = {number2} \n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
