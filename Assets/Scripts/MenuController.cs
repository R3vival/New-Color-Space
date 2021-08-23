using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject pantallaInicial;
    public GameObject menuPrincipal;
    public Animator animInicial;
    void Start()
    {
        
        StartCoroutine(InicioAplicacion());
        animInicial = pantallaInicial.GetComponent<Animator>();
    }


    void Update()
    {
        
    }
    IEnumerator InicioAplicacion() {
        yield return new WaitForSeconds(1);
        pantallaInicial.SetActive(true);
        yield return new WaitForSeconds(3);
        animInicial.SetBool("Desaparecer", true);
        yield return new WaitForSeconds(2);
        pantallaInicial.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
}
