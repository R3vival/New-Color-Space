using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosController : MonoBehaviour
{
    public Asteroide[] asteroides;
 // public GameObject[] asteroides;
    public GameObject[] disparadores;
    public int asteroideActual;

    void Start()
    {
        asteroideActual = 0; 
        StartCoroutine(Disparar());
    }

    IEnumerator Disparar(){
        int tiempo = Random.Range(1,3);
        int n2 = Random.Range(0, disparadores.Length);

        asteroides[asteroideActual].Ordenes(disparadores[n2].transform.position, Random.Range(0.05f, 0.08f), Random.Range(-0.03f, 0.03f));
     /* asteroides[asteroideActual].velocidad = Random.Range(0.05f, 0.1f);
        asteroides[asteroideActual].direccion = Random.Range(-0.05f, 0.05f);*/
        
        yield return new WaitForSeconds(tiempo);
        StartCoroutine(Disparar());
        if (asteroideActual < asteroides.Length-1) { asteroideActual++; }
        else { asteroideActual = 0; }
    }
}

