using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour
{
    public GameObject [] thePlatform;
    public Transform generator;
    private float distanceBetwwen;
    
    private float platformWidthMin=1;
    private float platformWidthMax=7;

    ObjectPoll thePoll;
    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;


    private int platformSelector;
    public GameObject[] thePlatforms;
    PlayerMovement movement;
    private float[] platformwidth;
    // Start is called before the first frame update
    void Start()
    {
        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
        movement= FindObjectOfType<PlayerMovement>();

        platformwidth = new float[thePlatforms.Length];
        for(int i =0; i< thePlatforms.Length; i++)
        {
            platformwidth[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
            if (transform.position.x < generator.position.x)


            {

                distanceBetwwen = Random.Range(platformWidthMin, platformWidthMax);


                heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);
                if (heightChange > maxHeight || heightChange < minHeight)
                {
                    heightChange = maxHeight;

                }

                else if (heightChange < minHeight)
                {
                    heightChange = minHeight;
                }


                platformSelector = Random.Range(0, thePlatforms.Length);
                transform.position = new Vector3(transform.position.x + platformwidth[platformSelector] + distanceBetwwen, heightChange, transform.position.z);
            if (movement.gameOver == false)
            {
                Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);
                
            }

        }
    }
    
}
