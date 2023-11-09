using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 4f;
    public float fuerzaSalto = 6f;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento horizontal
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        if (movimientoHorizontal != 0f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        { 
            animator.SetBool("isRunning", false);
        }

        Vector2 movimiento = new Vector2(movimientoHorizontal * velocidadMovimiento, rb.velocity.y);
        rb.velocity = movimiento;

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Mathf.Abs(rb.velocity.y) < 0.01f)
            {
                rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
            }
        }
    }
}