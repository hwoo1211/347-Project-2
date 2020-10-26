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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
