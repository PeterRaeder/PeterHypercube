using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void switchLevel(string LevelName)
    {
        Debug.Log(LevelName);
        SceneManager.LoadScene(LevelName);
    }
}
