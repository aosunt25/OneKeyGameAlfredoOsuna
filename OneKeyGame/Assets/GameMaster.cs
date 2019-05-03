using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public GameObject Player;
    public GameObject Palomitas;
    private GameObject ClonePalomitas;
    public GameObject Rocas;
    private GameObject RocasClon;
    public GameObject RocasGigante;
    private GameObject RocasGiganteClon;
    public Text vidaJugador;
    public Text puntajeJugadar;
    public static GameMaster instance = null;
    public GameObject gameOver;
    public float tiempoRocas = 0f;
    public float tiempoPalomitas = 0f;
    public float tiempoRocaGigante = 15f;
    private int vidasJugador = 3;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoRocas -= Time.deltaTime;
        tiempoPalomitas -= Time.deltaTime;
        tiempoRocaGigante -= Time.deltaTime;
        if (tiempoRocas <= 0f)
        {
            RocasClon = Instantiate(Rocas, new Vector3(Random.Range(-7, 7), 3.95f, 0f), transform.rotation) as GameObject;
            tiempoRocas = 1f;
        }
        if (tiempoRocaGigante <= 0f)
        {
            RocasGiganteClon = Instantiate(RocasGigante, new Vector3(Random.Range(-7, 7),5f, 0f), transform.rotation) as GameObject;
            tiempoRocaGigante = 15f;
        }
        if (tiempoPalomitas <= 0)
        {
            ClonePalomitas = Instantiate(Palomitas, new Vector3(Random.Range(-7, 7), 3.95f, 0f), transform.rotation) as GameObject;
            tiempoPalomitas = 2f;
        }
        if (vidasJugador == 0)
        { 
            Destroy(Player);
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }
    public void vidasDeJugador()
    {
        vidasJugador--;

        vidaJugador.text = "Vidas: " + vidasJugador;
    }
    public void puntaje()
    {
        score++;
        puntajeJugadar.text = "Puntaje: " + score;
    }
}
