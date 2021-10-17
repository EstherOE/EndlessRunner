using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerMovement movement;
    public Button restartGame;
    public Button mainScene;
    private Vector3 playerStartPoint;
    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<PlayerMovement>();
        platformStartPoint = platformGenerator.position;
        playerStartPoint = movement.transform.position;
        restartGame.gameObject.SetActive(false);
        mainScene.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        
    }

    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }

    

    public void gameOver()
    {
        restartGame.gameObject.SetActive(true);
        mainScene.gameObject.SetActive(true);

    }
}
