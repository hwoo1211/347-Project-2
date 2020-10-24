using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] notes;
    public Transform[] points;
    public Transform[] HitBoxes;
    public float beat;
    public float timer;

    private GameObject note;

    // Start is called before the first frame update
    void Start()
    {
        beat = (60f/130f * 2f);
        note = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        int idx = Random.Range(0, 4);
        if (timer > beat)
        {
            //note.AddComponent<Note>();
            //note.GetComponent<Note>().setBeat(beat);
            note = Instantiate(notes[idx], points[idx]);         
            note.transform.position = new Vector3(points[idx].position.x, points[idx].position.y, 2.0f);

            timer -= beat;
        }
        timer += Time.deltaTime;
    }

    public void setBeat(float bt)
    {
        beat = bt;
    }
}

