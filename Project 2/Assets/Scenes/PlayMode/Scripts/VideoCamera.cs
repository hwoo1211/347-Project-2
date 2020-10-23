using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Video;

public class VideoCamera : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool isPause;
    private bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = (!isPause) ? true : false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            videoPlayer.Play();
            gameStart = true;
        } 

        if(isPause)
        { 
            videoPlayer.Pause();
        }
        else
        {
            if(gameStart)
            {
                videoPlayer.Play();
            }
        }
    }
}
