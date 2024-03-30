using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float fuerzaImpulso = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            AplicarFuerza(Vector2.left);
        }

        // Movimiento hacia la derecha
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            AplicarFuerza(Vector2.right);
        }

        // Movimiento hacia arriba
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            AplicarFuerza(Vector2.up);
        }

        // Movimiento hacia abajo
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            AplicarFuerza(Vector2.down);
        }
    }

    private void AplicarFuerza(Vector2 direccion)
    {
        // Aplicar fuerza en la dirección indicada
        Vector2 fuerza = direccion * fuerzaImpulso;
        rb.AddForce(fuerza);
    }
}

