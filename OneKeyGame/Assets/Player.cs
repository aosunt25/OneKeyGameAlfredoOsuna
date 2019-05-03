using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float fMinX = -7f;
    public float velocidad;
    float fMaxX = 7f;
    int direccion = -1;
    Vector3 pisicionInicial;
    private int lifes = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (direccion)
            {
                case -1:

                    if (Input.GetKeyDown(KeyCode.Space)){
                        direccion = 1;
                    }

                    if (transform.position.x > fMinX){
                        gameObject.transform.Translate(new Vector3(-velocidad, 0, 0)); ;
                    }
                    else
                    {
                        direccion = 1;
                    }
                    break;
                case 1:

                    if (Input.GetKeyDown(KeyCode.Space)){
                        direccion = -1;
                    }
                //Moving Right
                    if (transform.position.x < fMaxX)
                    {
                        gameObject.transform.Translate(new Vector3(velocidad, 0, 0));
                    }
                    else
                    {
                        direccion = -1;
                    }
                break;
            }
            
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "roca")
        {
            GameMaster.instance.vidasDeJugador();
        }
        else
        {
            GameMaster.instance.puntaje();
        }
    }
}

