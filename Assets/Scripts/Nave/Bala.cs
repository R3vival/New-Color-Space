using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    void Start()
    {
        velocidad = 15;
    }

   
    void Update()
    {
        this.gameObject.transform.Translate(0,velocidad*Time.deltaTime,0);

    }
}
