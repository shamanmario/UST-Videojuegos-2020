using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 0.05f;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0); //Input
        
        animator.SetFloat("Horizontal", movimiento.x);
        animator.SetFloat("Vertical", movimiento.y);
        animator.SetFloat("Magnitud", movimiento.magnitude);
        
        transform.position = transform.position + movimiento * velocidad;
    }
}
