using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMM : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject CreditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        CreditsPanel.SetActive(false);
    }
public void OpenCredits()
    {
        CreditsPanel.SetActive(true);
        MainPanel.SetActive(false);
    }

    public void CloseCredits() 
    {
        CreditsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }


public void switchLevel(string LevelName)
    {
        Debug.Log(LevelName);
        SceneManager.LoadScene(LevelName);
    }
}
