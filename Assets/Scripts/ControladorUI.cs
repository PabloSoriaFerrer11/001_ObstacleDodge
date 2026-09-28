using UnityEngine;
using TMPro; // Necesario para TextMeshPro

public class ControladorUI : MonoBehaviour
{
    // Asigna el objeto Text (TMP) desde el Inspector
    public TextMeshProUGUI textoPuntos;

    // Referencia privada al script Scorer
    private Scorer scriptScorer;

    void Start()
    {
        // Busca en la escena el objeto que tiene el script Scorer (tu Player)
        scriptScorer = FindAnyObjectByType<Scorer>();

        ActualizarTexto();
    }

    void Update()
    {
        // Actualizamos el texto continuamente según el valor del score
        ActualizarTexto();
    }

    public void ActualizarTexto()
    {
        // Comprobamos que ambas referencias existan antes de asignar
        if (textoPuntos != null && scriptScorer != null)
        {
            textoPuntos.text = "Golpes: " + scriptScorer.score.ToString() + "\n\rPulsa 'C' para cambiar cámara";
        }
    }
}