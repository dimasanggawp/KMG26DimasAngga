using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{
    public string targetScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(targetScene);
    }
}
