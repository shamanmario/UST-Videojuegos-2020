using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 1;
    private Rigidbody2D rigidbody;
    public LogicaEscena controlador;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            rigidbody.velocity = Vector2.up * velocidad;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        controlador.perdiste();
    }
}
