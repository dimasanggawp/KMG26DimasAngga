using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed = 5f; //Kecedaran gerak objek
    public bool isMovingUp = true; //Status gerak objek
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0)) //Jika tombol mouse ditekan
        // {
        //     if(isMovingUp)
        //     {
        //         isMovingUp = false;
        //     }
        //     else
        //     {
        //         isMovingUp = true;
        //     }
        // }

        if (isMovingUp)
        {
            MoveUp();
        }
        else
        {
            MoveDown();
        }

        // //MoveUp();
        // if (Input.GetKey(KeyCode.W))
        // {
        //     MoveUp();
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     MoveDown();
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     MoveLeft();
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     MoveRight();
        // }
    }

    void MoveUp()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

}
