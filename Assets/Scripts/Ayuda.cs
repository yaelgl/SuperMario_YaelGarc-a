// Yael Michel García López A01750911

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Ayuda : MonoBehaviour
{
    // Referencias a los elementos de la interfaz de usuario
    private UIDocument menu;
    private Button botonR;
    private Button Salir;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener el UIDocument adjunto a este GameObject
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Manda a las escenas correspondientes al hacer click
        botonR = root.Q<Button>("BotonR");
        botonR.RegisterCallback<ClickEvent, String>(Jugar,"Menu");
       
        Salir = root.Q<Button>("Salir");
        Salir.RegisterCallback<ClickEvent, String>(Jugar,"Menu");
    }

    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        // Cargar la escena especificada
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
