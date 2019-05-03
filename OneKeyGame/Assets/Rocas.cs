using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocas : MonoBehaviour
{
   public float speed;

   

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Translate(new Vector3(0, -.08f, 0));

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
