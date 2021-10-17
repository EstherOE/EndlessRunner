using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionPt : MonoBehaviour
{

    public GameObject platformDestruction;
    // Start is called before the first frame update
    void Start()
    {
        platformDestruction = GameObject.Find("platformDestructionPt");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< platformDestruction.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
