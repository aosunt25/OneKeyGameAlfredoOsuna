using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palomitas : MonoBehaviour
{
    public float speed;



    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Translate(new Vector3(0, -.05f, 0));

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
       
            Destroy(gameObject);


    }
}
