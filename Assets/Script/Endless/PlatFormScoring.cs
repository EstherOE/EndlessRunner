using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlatFormScoring : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    PlayerMovement player;
    int score;
    public  static int bScore;
    // Start is called before the first frame update
    void Start()
    {
        bScore = 0;
        player= FindObjectOfType<PlayerMovement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        score = bScore;
        scoreText.text = "Score: " + Mathf.Round(score);
       

    }

   public void GetScore(int dscore)
    {
        score += dscore;
        scoreText.text = "Score: " + Mathf.Round(score);

    }


}
