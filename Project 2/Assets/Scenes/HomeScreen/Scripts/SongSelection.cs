using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SongSelection : MonoBehaviour
{

    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {        
        SceneManager.LoadScene("PlayMode");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
