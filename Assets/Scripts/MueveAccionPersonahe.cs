// Yael Michel García López A01750911

using UnityEngine;
using UnityEngine.InputSystem;

public class MueveAccionPersonaje : MonoBehaviour
{
    [SerializeField]
    
    private InputAction leftAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]

    // Acción de entrada para movimiento general
    private InputAction moveAction;

    private const float SPEED = 10.0F;

    // Habilita las acciones de entrada al inicio
    void Start()
    {
        leftAction.Enable();
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    // Obtiene la dirección del movimiento y mueve al personaje
    {   
            Vector2 move= moveAction.ReadValue<Vector2>();
            transform.position = (Vector2) transform.position + move * SPEED * Time.deltaTime;
        //if (leftAction.IsPressed())
        {

        }
    }
    
}


