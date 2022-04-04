using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    private Rigidbody arigidbody;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        arigidbody = GetComponent<Rigidbody>();
        arigidbody.AddForce(0, 0, -speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            Vector3 heading = other.transform.position - transform.position;
            Vector3 direction = -heading / heading.magnitude;
            arigidbody.velocity = direction * speed;
        }
    }
}
