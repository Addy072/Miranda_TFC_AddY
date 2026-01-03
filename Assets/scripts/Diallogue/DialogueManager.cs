using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public DialogueNode nodoActual;
    public DialogueUI ui;

    void Start()
    {
        MostrarNodo(nodoActual);
    }

    public void MostrarNodo(DialogueNode nodo)
    {
        nodoActual = nodo;
        ui.MostrarTexto(nodo.texto);
        ui.MostrarRetrato(nodo.personaje, nodo.emocion);
        ui.MostrarOpciones(nodo.opciones);
    }

    public void SeleccionarOpcion(DialogueOption opcion)
    {
        if (opcion.siguienteNodo != null)
            MostrarNodo(opcion.siguienteNodo);
        else
            ui.CerrarDialogo();
    }
}