using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public Text textoUI;
    public Image retratoUI;
    public Transform contenedorOpciones;
    public Button botonOpcionPrefab;

    private DialogueManager manager;

    void Awake()
    {
        manager = FindFirstObjectByType<DialogueManager>();
    }

    public void MostrarTexto(string texto)
    {
        textoUI.text = texto;
    }

    public void MostrarRetrato(DialogueCharacter personaje, Emotion emocion)
    {
        retratoUI.sprite = personaje.GetSprite(emocion, hablando: true);
    }

    public void MostrarOpciones(DialogueOption[] opciones)
    {
        foreach (Transform hijo in contenedorOpciones)
            Destroy(hijo.gameObject);

        foreach (var opcion in opciones)
        {
            var boton = Instantiate(botonOpcionPrefab, contenedorOpciones);
            boton.GetComponentInChildren<Text>().text = opcion.textoRespuesta;

            boton.onClick.AddListener(() =>
            {
                manager.SeleccionarOpcion(opcion);
            });
        }
    }

    public void CerrarDialogo()
    {
        gameObject.SetActive(false);
    }
}