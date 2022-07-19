using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int dificultad;
    public float tiempoSpawnMinimo;
    public float tiempoSpawnMaximo;
    public float velocidadMinima;
    public float velocidadMaxima;
    public int puntaje;
    public Text textPuntaje;

    void Start()
    {
        dificultad = 1;
        tiempoSpawnMinimo = 3;
        tiempoSpawnMaximo = 5;
        velocidadMinima = 0.05f;
        velocidadMaxima = 0.1f;
        puntaje = 0;
        StartCoroutine(AumentoDificultad());
        StartCoroutine(Puntaje());
    }

    IEnumerator AumentoDificultad()
    {
        yield return new WaitForSeconds(10);
        tiempoSpawnMinimo -= 0.2f;
        tiempoSpawnMaximo -= 0.5f;
        velocidadMinima += 0.05f;
        velocidadMaxima +=0.05f;
        StartCoroutine(AumentoDificultad());
    }

    IEnumerator Puntaje()
    {
        puntaje++;
        textPuntaje.text = "" + puntaje;
        yield return new WaitForSeconds(1);
        StartCoroutine(Puntaje());
    }

    public void JugarDenuevo()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
