using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SongSelection : MonoBehaviour
{

    public GameObject playB;
    public GameObject mainCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        playB.SetActive(false);
    }

    public void PlayGame()
    {
        //SceneManager.MoveGameObjectToScene();
        mainCanvas.SetActive(false);
        SceneManager.LoadScene("PlayMode");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
