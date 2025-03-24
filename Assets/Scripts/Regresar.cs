// Yael Michel García López A01750911

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Regresar : MonoBehaviour
{
    // Componentes de botonR y UIDocument
    private UIDocument menu;
    private Button botonR;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    // Configura el botón de regresar y asigna un evento para cambiar de escena
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonR = root.Q<Button>("BotonR");
        botonR.RegisterCallback<ClickEvent, String>(Jugar,"MENU");
    }
    // Carga la escena especificada cuando se hace clic en el botón
    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
