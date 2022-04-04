using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingBlocks : MonoBehaviour
{
    public GameObject prefabBlock;
    private float xPos;
    private float zPos;
    // Start is called before the first frame update
    void Start()
    {
        xPos = -3.5f;
        zPos = 2.5f;
        for (int i = 0; i < 3; i ++) {
            for (int j = 0; j < 8; j ++) {
                var block = Instantiate(prefabBlock, new Vector3(xPos, 0.15f, zPos), Quaternion.identity, transform);
                xPos += 1.01f;
            }
            zPos -= 1.5f;
            xPos = -3.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
