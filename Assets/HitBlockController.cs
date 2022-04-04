using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlockController : MonoBehaviour
{
    public int health = 3 + BlockController.level; //Random.Range(2, 5);
    public Color[] spectrum = new Color[5]{new Color(1f, 1f, 1f), new Color(0.9f, 0.6f, 0.1f), new Color(0.3f, 0.4f, 0.5f), Color.blue, Color.black};
    //spectrum[0] = Color.black; //, Color.blue, Color.magenta, Color.red, Color.yellow);
    //public Color color1 = Color.magenta;
    //public Color color2 = Color.red;
    //public Color color3 = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Ball") {
            health --;
            //Console.WriteLine(spectrum);
            if (health == 0) {
                Destroy(gameObject);
            }
           
            GetComponent<Renderer>().material.color = spectrum[health]; //Random.ColorHSV();
        }
    }
}
