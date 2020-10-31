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
                Configs.config.setOffset(1);
                Configs.config.setStretch(1.0f);
                break;
            case "2":
                Configs.config.setBpm(180);
                Configs.config.setTitle("cosmo");
                Configs.config.setOffset(1);
                Configs.config.setStretch(1.0f);
                break;
            case "3":
                Configs.config.setBpm (150);
                Configs.config.setTitle("flowering");
                Configs.config.setOffset(1);
                Configs.config.setStretch(1.0f);
                break;
            case "4":
                Configs.config.setBpm(300);
                Configs.config.setTitle("adele");
                Configs.config.setOffset(3);
                Configs.config.setStretch(0.92f);
                break;
        }
        Configs.config.setAudio(aClip);
        Configs.config.setVideo(vClip);
    }
}
