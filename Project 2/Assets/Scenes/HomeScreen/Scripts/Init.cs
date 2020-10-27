using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class Init : MonoBehaviour
{
    public VideoClip[] clips;
    private VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private void Awake()
    //{
    //    int idx = Random.Range(0, 3);
    //    VideoClip toPlay = clips[idx];
    //    player = GameObject.Find("Background").GetComponent<VideoPlayer>();
    //    player.clip = toPlay;
    //    player.isLooping = true;
    //    player.Play();
    //}

    // Update is called once per frame
    void Update()
    {

    }
}
