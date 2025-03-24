// Yael Michel García López A01750911

using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    // indica si el personaje esta en Piso
    public static bool enPiso {get; private set;}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enPiso=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Identifica si esta en piso o si no con trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}
