using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float beat;
    public float speed;
    public bool isHittable;
    public string color;

    public KeyCode hitKey;


    // Start is called before the first frame update
    void Start()
    {
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
        if(Input.GetKeyDown(hitKey) && isHittable)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        this.transform.position -= new Vector3(0.0f, beat * Time.deltaTime, 0.0f);
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
        if(collision.tag == "Hitbox")
        {
            isHittable = true;
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
