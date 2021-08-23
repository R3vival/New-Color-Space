using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameController controlador;
    private float velocidad;
    void Start()
    {
        velocidad = Random.Range(controlador.velocidadMinima, controlador.velocidadMaxima);
    }

    void Update()
    {
        this.gameObject.transform.Translate(0,-velocidad,0);
    }
}
