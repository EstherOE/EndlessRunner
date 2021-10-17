using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ItemscoreText;
    public TextMeshProUGUI GameOverText;
    public float Score;
   


    public bool scoreIncreasing;
    public int pointPerSecond;
    PlayerMovement movement;

   float items;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.gameObject.SetActive(false);
        
        movement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.gameOver == false)
        {
            if (scoreIncreasing)
            {
                Score += pointPerSecond * Time.deltaTime;
            }

            scoreText.text = "Score: " + Mathf.Round(Score);
            
        }
    }

    public void Death()
    {

        GameOverText.gameObject.SetActive(true);
    }
    public void GetScore(int dscore)
    {
        if (movement.gameOver == false)
        {
            items += dscore;

            ItemscoreText.text = "ItemScore: " + Mathf.Round(items);
        }
       
    }

}
