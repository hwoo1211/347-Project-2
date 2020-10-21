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
    public bool startGame;
    public bool endGame;
    public float clipLength;

    private GameObject note;
    private AudioSource aSource;
    

    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
        endGame = false;
        beat = (60f/135f * 2f);
        note = new GameObject();
        aSource = GetComponent<AudioSource>();
        timer = 1.0f;
        clipLength = aSource.clip.length;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && !startGame && !endGame)
        {
            startGame = true;
            aSource.Play();
        }

        if(startGame)
        {
            int idx = Random.Range(0, 4);
            if (timer > beat)
            {
                note.AddComponent<Note>();          
                note.GetComponent<Note>().setBeat(beat);
                
                note = Instantiate(notes[idx], points[idx]);
                note.transform.position = new Vector3(points[idx].position.x, points[idx].position.y, 2.0f);

                note.AddComponent<BoxCollider2D>();
                note.GetComponent<BoxCollider2D>().isTrigger = true;

                timer -= beat;
            }
            timer += Time.deltaTime;

            if (aSource.time > clipLength - 10.0f)
            {
                startGame = false;
                endGame = true;
            }
        }
    }

    public void setBeat(float bt)
    {
        beat = bt;
    }
}

