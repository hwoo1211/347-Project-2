using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AlbumCoverChange : MonoBehaviour
{
    private GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        img = GameObject.Find("Image");
        img.SetActive(false);
        GameObject songPanel = GameObject.Find("SongSelectWindow");
        songPanel.SetActive(false);

        GameObject creditsPanel = GameObject.Find("CreditsWindow");
        creditsPanel.SetActive(false);

        GameObject helpPanel = GameObject.Find("HelpWindow");
        helpPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
