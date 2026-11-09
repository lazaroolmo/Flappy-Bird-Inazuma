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
        LevelController levelController = FindAnyObjectByType<LevelController>();
        if (levelController)
        {
            SeguidordePuntos.Instancia.ConfirmarPuntos();
            levelController.LoadNextLevel();
        }
    }
}
