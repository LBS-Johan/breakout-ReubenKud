using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapwningBlocks : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Block;
    public float howManyBlocks;

    void Start()
    {
        Spawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawning()
    {
        for (float col = -3.5f; col < 4.5f; col++)
        {
            for (float row = 0; row<howManyBlocks;row++)
            {
                Vector2 spawnLocation = new Vector2(col*3, row*1.5f);
                Instantiate(Block, spawnLocation, Quaternion.identity);
            }
            
        }
    }
}
