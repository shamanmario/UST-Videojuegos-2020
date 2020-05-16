using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasico : MonoBehaviour
{
    public float velocidad = 0.05f;

    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //vector (X, Y, Z);
        Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        animator.SetFloat("Horizontal", movimiento.x);
        animator.SetFloat("Vertical", movimiento.y);
        animator.SetFloat("Magnitud", movimiento.magnitude);
        
        transform.position = transform.position + movimiento * velocidad;
    }
}
