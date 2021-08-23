using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public float velocidad;
    public float direccion;
    public GameController controlador;
    public Vector3 pos;
    public Vector3 posInicial;
  
    void Start()
    {
        posInicial = this.gameObject.transform.position;
    }

    void Update()
    {
        this.gameObject.transform.Translate(direccion, -velocidad, 0);
    }

    public void Ordenes(Vector3 _posicion, float _velocidad, float _direccion)
    {
        gameObject.transform.position = _posicion;
        velocidad = _velocidad;
        direccion = _direccion;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Proyectil")
        {
            VolverOrigen();
            controlador.puntaje += 5;
        }
    }

    public void VolverOrigen()
    {
        transform.position = posInicial;
        velocidad = 0;
        direccion = 0;
    }
}
