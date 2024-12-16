using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadLine = -10;
    //private Collision col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if (transform.position.x < this.deadLine) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag") {
            audio.Play();
        }
    }
}
