using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void quit()
    {
        Application.Quit();
    }

    public void Tolink(string link)
    {
        Application.OpenURL(link);
    }
}
