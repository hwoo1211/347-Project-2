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

    private Text comboText;
    private Text comboNumberText;
    private Text hitNotesText;
    private Text missNotesText;
    private Text hitRateText;
    private Text rankText;

    private GameObject ResultsPanel;
    private GameObject PausePanel;
    private bool isPaused;
    private bool isEnd;
    private UnityEngine.UI.Button restartButton;
    private UnityEngine.UI.Button menuButton;

    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;

        comboText = GameObject.Find("ComboText").GetComponent<Text>();
        comboNumberText = GameObject.Find("ComboNumber").GetComponent<Text>();

        hitNotesText = GameObject.Find("HitNotesText").GetComponent<Text>();
        missNotesText = GameObject.Find("MissNotesText").GetComponent<Text>();
        hitRateText = GameObject.Find("HitRateText").GetComponent<Text>();
        rankText = GameObject.Find("RankText").GetComponent<Text>();

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

        comboText.text = "Combo!";
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
       
        if(justNotes != 0 )
        {
            percentage = ((float)justNotes) / ((float)missedNotes + (float)justNotes) * 100.0f;
        }

        if (isEnd)
        {
            hitNotesText.text = "Hit Notes: " + justNotes.ToString();
            missNotesText.text = "Missed Notes: " + missedNotes.ToString();

            

            hitRateText.text = "Hit Rate: " + percentage.ToString("F2");
            string rank = "";

            if (percentage > 99.0)
            { rank = "SS"; }

            if (percentage < 99 && percentage >= 95)
            { rank = "S"; }

            if(percentage < 95 && percentage >= 90)
            { rank = "A"; }

            if(percentage < 90 && percentage >= 80)
            { rank = "B"; }

            if(percentage < 80)
            { rank = "C"; }

            rankText.text = "Final Rank: " + rank;

            ResultsPanel.gameObject.SetActive(true);
            PausePanel.gameObject.SetActive(false);

            comboNumberText.gameObject.SetActive(false);
            comboText.text = "";
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
}
