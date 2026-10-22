using UnityEngine;

public class ScalingObject : MonoBehaviour
{
    public bool isScaling = true;
    public float scaleSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ScaleUp();
        //ScaleDown();
        if(Input.GetMouseButtonDown(0)) //Jika tombol mouse ditekan
        {
            if(isScaling)
            {
                isScaling = false;
            }
            else
            {
                isScaling = true;
            }
        }

        if (isScaling)
        {
            ScaleUp();
        }
        else
        {
            ScaleDown();
        }
    }

    void ScaleUp()
    {
        transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
    }

    void ScaleDown()
    {
        transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
