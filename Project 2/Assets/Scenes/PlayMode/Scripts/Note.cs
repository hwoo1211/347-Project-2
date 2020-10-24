using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Transform[] points;
    public float beat;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //beat = 60f / 130f * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        this.transform.position -= new Vector3(0.0f, beat * Time.deltaTime, 0.0f);

        //Vector3 compVec = new Vector3(0.0f, -8.0f, 0.0f);

        if (this.transform.position.y <= -8)
            Destroy(this.gameObject);
    }

    public void setBeat(float bt)
    {
        beat = bt;
    }

    float getBeat()
    {
        return beat;
    }
}
