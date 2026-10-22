using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public GameObject objectBerubahWarna;
    public Color warnaBaru;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ChangeColor(warnaBaru);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(Color newColor)
    {
        SpriteRenderer spriteRenderer = objectBerubahWarna.GetComponent<SpriteRenderer>();
        spriteRenderer.color = newColor;
    }

    public void UbahMerah()
    {
        ChangeColor(Color.red);
    }

    public void UbahKuning()
    {
        ChangeColor(Color.yellow);
    }

    public void UbahHijau()
    {
        ChangeColor(Color.green);
    }
}
