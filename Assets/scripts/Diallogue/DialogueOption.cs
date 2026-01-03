using UnityEngine;

[System.Serializable]
public class DialogueOption
{
    public string textoRespuesta;
    public DialogueNode siguienteNodo;
}

public enum Emotion
{
    Neutral,
    Feliz,
    Enfadado,
    Confundido
}

[CreateAssetMenu(fileName = "NodoDialogo", menuName = "Dialogo/Nodo")]
public class DialogueNode : ScriptableObject
{
    [TextArea(3, 10)]
    public string texto;

    public DialogueCharacter personaje;  
    public Emotion emocion;

    public DialogueOption[] opciones;
}