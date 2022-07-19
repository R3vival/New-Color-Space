using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraColor : MonoBehaviour
{
    public Sprite[] colores;
    public SpriteRenderer apariencia;
    void Start()
    {
        apariencia = this.gameObject.GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        
    }
}
