using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configs : MonoBehaviour
{
    public static Configs config;

    static int bpm;
    static string title;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        config = this;
        bpm = 0;
        title = "";
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
}
