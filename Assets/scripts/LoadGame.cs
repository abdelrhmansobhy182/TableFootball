using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void load(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void exit()
    {
        Application.Quit();
    }
}
