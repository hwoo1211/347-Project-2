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
    public bool isPause;
    public float clipLength;

    private GameObject note;
    private AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
        endGame = false;
        isPause = false;
        beat = (60f / 185f * 2f);
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = (!isPause) ? true : false;
        }

        if (isPause)
        {
            aSource.Pause();
        }
        else
        {
            aSource.UnPause();
        }

        if (startGame && !isPause)
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

                note.AddComponent<Rigidbody2D>();
                note.GetComponent<Rigidbody2D>().isKinematic = true;
                note.GetComponent<Rigidbody2D>().useFullKinematicContacts = true;

                timer -= beat;
            }
            timer += Time.deltaTime;

            if (aSource.time > clipLength - 20.0f)
            {
                startGame = false;
                endGame = true;
            }
        }

        if(!aSource.isPlaying && endGame)
        {
            theGame.game.setEnd();
        }
    }

    public void setBeat(float bt)
    {
        beat = bt;
    }
}
