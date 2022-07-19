using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEnemigos : MonoBehaviour
{
    public GameObject[] portales;
    public GameObject[] lanzadores;
    public GameController controlador;
    public float tiempo;

    void Start()
    {
        StartCoroutine(CrearPortal());
    }

    void Update()
    {
        
    }

    IEnumerator CrearPortal()
    {
        tiempo = Random.Range(controlador.tiempoSpawnMinimo, controlador.tiempoSpawnMaximo);
        int portal = Random.Range(0,portales.Length);
        int lanzador = Random.Range(0, lanzadores.Length);
        Instantiate(portales[portal], lanzadores[lanzador].transform.position, lanzadores[lanzador].transform.rotation);
        yield return new WaitForSeconds(tiempo);
        StartCoroutine(CrearPortal());
    }
}
