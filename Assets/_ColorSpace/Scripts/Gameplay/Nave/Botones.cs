using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public Button botonDerecha;
    public Button botonIzquierda;
    public GameObject flechaDerecha;
    public GameObject flechaIzquierda;
    public Sprite[] derecha;
    public Sprite[] derechaPresionada;
    public Sprite[] izquierda;
    public Sprite[] izquierdaPresionada;
    public SpriteRenderer aparienciaDerecha;
    public SpriteRenderer aparienciaIzquierda;

    void Start()
    {
        aparienciaDerecha = flechaDerecha.GetComponent<SpriteRenderer>();
        aparienciaIzquierda = flechaIzquierda.GetComponent<SpriteRenderer>();
        botonDerecha = flechaDerecha.GetComponent<Button>();
    }


    void Update()
    {
       
    }
}
