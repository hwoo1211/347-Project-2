using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For UI (Text, images, etc)
using UnityEngine.UIElements;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System.Dynamic;

public class theGame : MonoBehaviour
{
    public int comboNumber;

    public static theGame game;

    public int justNotes;
    public int missedNotes;
    public float percentage;

   // private Text comboText;
    private Text comboNumberText;
    private Text hitNotesText;
    private Text missNotesText;
    private Text hitRateText;
    private Text rankText;
    private Text scoreText;

    private GameObject ResultsPanel;
    private GameObject PausePanel;
    private bool isPaused;
    private bool isEnd;
    private UnityEngine.UI.Button restartButton;
    private UnityEngine.UI.Button menuButton;

    private UnityEngine.UI.Button backToMenuButton;
    private UnityEngine.UI.Button retryButton;

    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;

       // comboText = GameObject.Find("ComboText").GetComponent<Text>();
        comboNumberText = GameObject.Find("ComboNumber").GetComponent<Text>();

        hitNotesText = GameObject.Find("HitNotesTextNum").GetComponent<Text>();
        missNotesText = GameObject.Find("MissNotesTextNum").GetComponent<Text>();
        hitRateText = GameObject.Find("HitRateTextNum").GetComponent<Text>();
        rankText = GameObject.Find("RankTextNum").GetComponent<Text>();
        scoreText = GameObject.Find("ScoreTextNum").GetComponent<Text>();

        restartButton = GameObject.Find("RestartButton").GetComponent<UnityEngine.UI.Button>();
        menuButton = GameObject.Find("MenuButton").GetComponent<UnityEngine.UI.Button>();

        backToMenuButton = GameObject.Find("BackToMenu").GetComponent<UnityEngine.UI.Button>();
        retryButton = GameObject.Find("Retry").GetComponent<UnityEngine.UI.Button>();

        restartButton.onClick.AddListener(restart);
        menuButton.onClick.AddListener(backToMenu);

        backToMenuButton.onClick.AddListener(backToMenu);
        retryButton.onClick.AddListener(restart);

        isPaused = false;

        game = this;
        comboNumber = 0;
        ResultsPanel = GameObject.Find("ResultsPanel");
        ResultsPanel.gameObject.SetActive(false);

        PausePanel = GameObject.Find("PausePanel");
        PausePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        comboNumberText.text = "Combo x " + comboNumber.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            changePauseStatus();
        }

        if (isPaused && !isEnd)
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

    public void setEnd()
    {
        isEnd = !isEnd ? true : false;
    }

    public bool getEnd()
    {
        return isEnd;
    }

    private void changePauseStatus()
    {
        isPaused = (!isPaused) ? true : false;
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void backToMenu()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void activateResults()
    {
        hitNotesText.text = justNotes.ToString();
        missNotesText.text = missedNotes.ToString();

        scoreText.text = GameObject.Find("Score").GetComponent<Text>().text;

        hitRateText.text = percentage.ToString("F2");
        string rank = "";

        if (percentage > 99.0)
        { rank = "SS"; }

        if (percentage < 99 && percentage >= 95)
        { rank = "S"; }

        if (percentage < 95 && percentage >= 90)
        { rank = "A"; }

        if (percentage < 90 && percentage >= 80)
        { rank = "B"; }

        if (percentage < 80)
        { rank = "C"; }

        rankText.text = rank;

        ResultsPanel.gameObject.SetActive(true);
        PausePanel.gameObject.SetActive(false);
    }

    public void calculatePercentage()
    {
        if (justNotes != 0)
        {
            percentage = ((float)justNotes) / ((float)missedNotes + (float)justNotes) * 100.0f;
        }
    }
}
