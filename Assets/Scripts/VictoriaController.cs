using UnityEngine;

public class VictoriaController : MonoBehaviour
{
    [SerializeField] GameObject textoDeVictoria;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

            // CONFIRMAMOS LOS PUNTOS PONIENDOLOS COMO CHECKPOINT
            if (SeguidordePuntos.Instancia != null)
            {
                SeguidordePuntos.Instancia.ConfirmarPuntos();
            }

            // CONGELAMOS EL TIEMPO PARA QUE TODO PARE
            Time.timeScale = 0f; 
        }
    }
}