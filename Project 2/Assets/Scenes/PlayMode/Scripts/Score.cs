using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    private int multiplier = 1;
    private readonly int point = 10;
    int totalPoints = 0;
    public Animator animator;

    public void AddScore()
    {
        switch (multiplier)
        {
            case 1:
                animator.Play("HitAni");
                break;
            case 2:
            case 3:
            case 4:
                animator.Play("GoodAni");
                break;
            default:
                animator.Play("PerfAni");
                break;
        }
        totalPoints += multiplier++ * point;
        scoreText.text = totalPoints.ToString("000");
        
        
    }

    public void MissScore()
    {
        animator.Play("MissAni");
        totalPoints -= point;
        multiplier = 1;
        scoreText.text = totalPoints.ToString("000");
    }
}
