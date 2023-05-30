using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorScenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerPrefs.SetInt("DoTutorialOnce", 0);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            PlayerPrefs.SetInt("DoTutorialOnce", 3);
        }
    }

    public void ChangeScene(string name)
    {
        if(PlayerPrefs.GetInt("DoTutorialOnce") == 3)
        {
            SceneManager.LoadScene(name);
        }

        else if(PlayerPrefs.GetInt("DoTutorialOnce") != 3)
        {
            SceneManager.LoadScene("Tutorial");
        }
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void goback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    
}
