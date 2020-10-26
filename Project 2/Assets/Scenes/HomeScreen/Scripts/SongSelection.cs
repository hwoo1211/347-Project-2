using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class SongSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        // Suggestion: Use SceneManager.MoveGameObjectToScene() to add song info to PlayMode Scene
        SceneManager.LoadScene("PlayMode");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
