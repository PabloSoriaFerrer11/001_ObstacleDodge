using Unity.Cinemachine; // o Cinemachine según la versión
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineCamera camaraPrincipal;
    public CinemachineCamera camaraSecundaria;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int auxiliar = camaraSecundaria.Priority;
            // Activar la cámara secundaria subiendo su prioridad
            camaraSecundaria.Priority = camaraPrincipal.Priority;
            camaraPrincipal.Priority = auxiliar;
        }
    }
}