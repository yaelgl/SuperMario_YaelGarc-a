// Yael Michel García López A01750911

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    // Declaramos los componentes y botones
    private UIDocument menu;
    private Button botonA;
    private Button botonB;
    private Button botonC;
    private Button Salir;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Configura los botones de la interfaz y asigna eventos para cambiar de escena
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonA = root.Q<Button>("BotonA");
        botonA.RegisterCallback<ClickEvent, String>(Jugar,"Jugar");
        botonB = root.Q<Button>("BotonB");
        botonB.RegisterCallback<ClickEvent, String>(Jugar,"Ayuda");
        botonC = root.Q<Button>("BotonC");
        botonC.RegisterCallback<ClickEvent, String>(Jugar,"Creditos");
        Salir = root.Q<Button>("Salir");
        Salir.RegisterCallback<ClickEvent, String>(Jugar,"Menu");
    }
    // Carga la escena especificada
    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
