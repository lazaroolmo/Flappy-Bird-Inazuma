using UnityEngine;

public class NextLevelCollisionController : MonoBehaviour
{
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
        // BUSCA EN LevelController
        LevelController levelController = FindAnyObjectByType<LevelController>();
        if (levelController) // SI NO ES NULO
        {
            SeguidordePuntos.Instancia.ConfirmarPuntos(); // CONVIERTE LOS PUNTOS ACTUALES EN CHECKPOINT
            levelController.LoadNextLevel(); // CARGA EL SIGUIENTE NIVEL
        }
    }
}
