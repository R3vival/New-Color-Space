using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public Botones botones;
    public float speed;
    private SpriteRenderer apariencia;
    public int cambioColor;
    public Sprite[] sprites;
    public string[] tags = { "Verde", "Naranjado", "Rosado", "Morado", "Azul" };

    public GameObject bala;
    public GameObject lanzador1;
    public GameObject lanzador2;
   /* public GameObject pantallaMuerte;
    public GameObject pantallaGamePlay;*/
    public BarraColor barra;

    public bool disparar;

    public GameController controlador;
    void Start()
    {
       /* apariencia = this.gameObject.GetComponent<SpriteRenderer>();

        int colorInicial = Random.Range(1, sprites.Length);
        apariencia.sprite = sprites[colorInicial - 1];
        this.gameObject.tag = tags[colorInicial - 1];
        barra.apariencia.sprite = barra.colores[colorInicial - 1];*/
        disparar = true;
       /* pantallaMuerte.SetActive(false);
        pantallaGamePlay.SetActive(true);*/
    }


    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);
    }


    //MOVIMIENTO
    public void Izquierda()
    {
        speed = -0.1f;
    }
    public void Derecha()
    {
        speed = 0.1f;
    }
    public void Central()
    {
        speed = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(gameObject);

        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Proyectil") { Debug.Log("es un proyectil"); }
        else if (collision.gameObject.tag != this.gameObject.tag)
        {
            Destroy(gameObject);
            Debug.Log("Me mató un trigger");
         /*   pantallaGamePlay.SetActive(false);
            pantallaMuerte.SetActive(true);*/
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == this.gameObject.tag)
        {
            int nuevoColor = Random.Range(1, sprites.Length);
            controlador.puntaje += 10;
            apariencia.sprite = sprites[nuevoColor - 1];
            this.gameObject.tag = tags[nuevoColor - 1];
            barra.apariencia.sprite = barra.colores[nuevoColor - 1];
        }
    }

    public void Disparo()
    {
        if (disparar == true)
        {
            Instantiate(bala, lanzador1.transform.position, lanzador1.transform.rotation);
            Instantiate(bala, lanzador2.transform.position, lanzador2.transform.rotation);
            disparar = false;
            StartCoroutine(EnfriamientoDisparo());
        }
    }

    IEnumerator EnfriamientoDisparo()
    {
        yield return new WaitForSeconds(5);
        disparar = true;
    }
}