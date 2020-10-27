using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonListeners : MonoBehaviour
{

    private Button startButton;
    private Button credButton;
    private Button exitButton;

    private GameObject credPanel;
    // Start is called before the first frame update
    void Start()
    {
        credPanel = GameObject.Find("Credits");
        startButton = GameObject.Find("BeginButton").GetComponent<Button>();
        credButton = GameObject.Find("CreditsButton").GetComponent<Button>();
        exitButton = GameObject.Find("ExitButton").GetComponent<Button>();

        startButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        credButton.onClick.AddListener(() =>
        {
            credPanel.SetActive(true);
        });

        exitButton.onClick.AddListener(() =>
        {
            credPanel.gameObject.SetActive(false);
        });


        credPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
