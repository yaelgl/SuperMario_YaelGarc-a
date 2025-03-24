// Yael Michel García López A01750911

using System;
using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    // Componenetes para manejar la animacion y movimiento
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener componentes del GameObject
        rb=GetComponent<Rigidbody2D>();
        spRenderer=GetComponent<SpriteRenderer>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Animator, actualiza es estado de en piso y velocidad para cambiar animacion
        animator.SetFloat("velocidadX1", MathF.Abs(rb.linearVelocityX));
        animator.SetBool("enPiso", EstadoPersonaje.enPiso);
        // RENDERER
        spRenderer.flipX = rb.linearVelocityX < 0;
    }
    
    
}
