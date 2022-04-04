using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlockController : MonoBehaviour
{
    public Text LevelText;
    
    static public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0) {
            //if (SceneManager.GetActiveScene().name == "Level1") {
                //SceneManager.LoadScene("Level2");
            //} else {
                SceneManager.LoadScene("Level1");
                level += 1;
                GetComponent<Text>().text = "Level: " + level;
            //}
        }
    }
}
