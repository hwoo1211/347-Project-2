using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For UI (Text, images, etc)
using UnityEngine.UIElements;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class theGame : MonoBehaviour
{
    public int comboNumber;

    public static theGame game;

    public int justNotes;
    public int missedNotes;

    private Text comboText;
    private GameObject ResultsPanel;
    private GameObject PausePanel;
    private bool isPaused;
    private UnityEngine.UI.Button restartButton;
    private UnityEngine.UI.Button menuButton;

    // Start is called before the first frame update
    void Start()
    {
        restartButton = GameObject.Find("RestartButton").GetComponent<UnityEngine.UI.Button>();
        menuButton = GameObject.Find("MenuButton").GetComponent<UnityEngine.UI.Button>();

        restartButton.onClick.AddListener(restart);

        isPaused = false;
        game = this;
        comboNumber = 0;
        comboText = GameObject.Find("ComboNumber").GetComponent<Text>();
        ResultsPanel = GameObject.Find("ResultsPanel");
        ResultsPanel.gameObject.SetActive(false);

        PausePanel = GameObject.Find("PausePanel");
        PausePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        comboText.text = comboNumber.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            changePauseStatus();    
        }

        if (isPaused)
        {
            PausePanel.gameObject.SetActive(true);
        }
        else
        {
            PausePanel.gameObject.SetActive(false);
        }
    }

    public void incrementCombo()
    {
        comboNumber++;
        justNotes++;
    }

    public void resetCombo()
    {
        comboNumber = 0;
        missedNotes++;
    }

    private void changePauseStatus()
    {
        isPaused = (!isPaused) ? true : false;
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
