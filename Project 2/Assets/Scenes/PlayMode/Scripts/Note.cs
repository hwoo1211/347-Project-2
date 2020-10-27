using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float beat;
    public float speed;
    public bool isHittable;
    public string color;

    public bool isPaused;
    public float offset;

    public KeyCode hitKey;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;

        color = this.tag;
        switch (color)
        {
            case "Yellow":
                hitKey = KeyCode.D;
                break;

            case "Green":
                hitKey = KeyCode.F;
                break;

            case "Red":
                hitKey = KeyCode.J;
                break;

            case "Blue":
                hitKey = KeyCode.K;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(hitKey) && isHittable)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = (!isPaused) ? true : false;
        }
    }

    void FixedUpdate()
    {
        offset = beat * Time.deltaTime * 2f;
        if (isPaused)
        {
            offset = 0;
        }
        this.transform.position -= new Vector3(0.0f, offset, 0.0f);
    }

    public void setBeat(float bt)
    {
        beat = bt;
    }

    float getBeat()
    {
        return beat;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hitbox")
        {
            isHittable = true;
        }

        if (collision.tag == "Buttons")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Hitbox")
        {
            isHittable = false;
        }
    }
}