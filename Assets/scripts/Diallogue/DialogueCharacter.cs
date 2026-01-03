using UnityEngine;

[CreateAssetMenu(fileName = "PersonajeDialogo", menuName = "Dialogo/Personaje")]
public class DialogueCharacter : ScriptableObject
{
    public string nombre;

    // Retratos base
    public Sprite bocaCerrada;
    public Sprite bocaAbierta;

    // Emociones sin hablar
    public Sprite feliz;
    public Sprite enfadado;
    public Sprite confundido;

    // Emociones hablando
    public Sprite felizHablando;
    public Sprite enfadadoHablando;
    public Sprite confundidoHablando;

    public Sprite GetSprite(Emotion emocion, bool hablando)
    {
        if (!hablando)
        {
            return emocion switch
            {
                Emotion.Feliz => feliz,
                Emotion.Enfadado => enfadado,
                Emotion.Confundido => confundido,
                _ => bocaCerrada
            };
        }
        else
        {
            return emocion switch
            {
                Emotion.Feliz => felizHablando,
                Emotion.Enfadado => enfadadoHablando,
                Emotion.Confundido => confundidoHablando,
                _ => bocaAbierta
            };
        }
    }
}