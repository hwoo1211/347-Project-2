using UnityEngine;

public class Points : MonoBehaviour
{
    public ButtonHandler MyButton;
    public Score Score;
    public Spawner spawner;

    private bool objIn;
    private int kDown;

    private Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        objIn = false;  // Note Object is in Contact
        kDown = 0;      // key is up
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawner.isPause && spawner.startGame && !spawner.endGame && Input.GetKeyDown(MyButton.pressKey))
        {
            if (kDown == 0)
            {
                kDown = 1;  // key is down
                Count();
            }
            
        }
        else
        {
            kDown = 0;
        }
            

        
    }

    private void Count()
    {
        if (kDown == 1)
        {
            
            if (objIn)
            {
                Score.AddScore();
                objIn = false;
                if (coll)
                    Destroy(coll.gameObject);

            }
            else
                Score.MissScore();
            


        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objIn = true;
        coll = collision;
        //print("Entering: " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (objIn)
        {
            coll = null;
            Score.MissScore();
        }
        

    }

}
