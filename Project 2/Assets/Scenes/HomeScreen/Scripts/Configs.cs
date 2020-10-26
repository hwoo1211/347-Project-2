using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Configs : MonoBehaviour
{
    public static Configs config;

    static int bpm;
    static string title;
    static AudioClip aClip;
    static VideoClip vClip;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (config == null)
        {
            config = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        config = this;
        bpm = 0;
        title = "";
        aClip = null;
        vClip = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            Debug.Log(bpm + ", " + title);
        }
    }

    public void setBpm(int b)
    {
        Configs.bpm = b;
    }

    public int getBpm()
    {
        return bpm;
    }

    public void setTitle(string t)
    {
        Configs.title = t;
    }

    public string getTitle()
    {
        return title;
    }

    public void setAudio(AudioClip audio)
    {
        Configs.aClip = audio;
    }

    public AudioClip getAudio()
    {
        return Configs.aClip;
    }

    public void setVideo(VideoClip video)
    {
        Configs.vClip = video;
    }

    public VideoClip getVideo()
    {
        return Configs.vClip;
    }

}
