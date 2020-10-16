using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] notes;
    public Transform[] points;
    public float bpm;
    public float timer;

    private GameObject note;

    // Start is called before the first frame update
    void Start()
    {
        bpm = 5;
        note = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        int idx = Random.Range(0, 4);
        if(timer > bpm)
        {
            note = Instantiate(notes[idx], points[idx]);
            note.transform.position = new Vector3(points[idx].position.x, points[idx].position.y, 2.0f);
       
            timer -= bpm;
        }
        note.transform.position -= new Vector3(0f, bpm * Time.deltaTime, 0f);
        timer += Time.deltaTime; 
    }
}
