using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private SpriteRenderer spRen;

    public Sprite defaultButton;
    public Sprite pressedButton;
    public KeyCode pressKey;


    // Start is called before the first frame update
    void Start()
    {
        spRen = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pressKey))
        {
            spRen.sprite = pressedButton;
        }
        if (Input.GetKeyUp(pressKey))
        {
            spRen.sprite = defaultButton;
        }

    }


}