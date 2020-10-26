using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ConfigChange : MonoBehaviour
{
    public Button bttn;
    public AudioClip aClip;
    public VideoClip vClip;
    // Start is called before the first frame update
    void Start()
    {
        bttn.onClick.AddListener(changeSettings);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSettings()
    {
        switch (bttn.gameObject.tag)
        {
            case "1":
                Configs.config.setBpm(185);
                Configs.config.setTitle("123");               
                break;
            case "2":
                Configs.config.setBpm(180);
                Configs.config.setTitle("cosmo");
                break;
            case "3":
                Configs.config.setBpm (150);
                Configs.config.setTitle("flowering");
                break;
        }
        Configs.config.setAudio(aClip);
        Configs.config.setVideo(vClip);
    }
}
