using UnityEngine;

public class VictoriaController : MonoBehaviour
{
    [SerializeField] GameObject textoDeVictoria; // Aquí arrastraremos el texto oculto

    private void OnTriggerEnter(Collider other)
    {
        // SI EL PLAYER CRUZA LA META
        if (other.CompareTag("Player"))
        {
            // MOSTRAMOS EL TEXTO QUE ESTABA OCULTO
            if (textoDeVictoria != null)
            {
                textoDeVictoria.SetActive(true);
            }

            // CONFIRMAMOS LOS PUNTOS
            if (SeguidordePuntos.Instancia != null)
            {
                SeguidordePuntos.Instancia.ConfirmarPuntos();
            }

            // CONGELAMOS EL TIEMPO PARA QUE TODO PARE
            Time.timeScale = 0f; 
        }
    }
}