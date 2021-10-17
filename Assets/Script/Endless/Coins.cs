using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    ScoreManager pscore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        pscore = FindObjectOfType<ScoreManager>();
    }

  public  void Score()
    {

        pscore.GetScore(score);

    }

}
