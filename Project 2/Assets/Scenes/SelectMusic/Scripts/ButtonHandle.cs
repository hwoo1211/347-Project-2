using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandle : MonoBehaviour
{
    private Button toPlayMode;
    // Start is called before the first frame update
    void Start()
    {
        toPlayMode = GameObject.Find("PlayButton").GetComponent<Button>();
        toPlayMode.onClick.AddListener(() =>
        {
            Debug.Log("click");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
