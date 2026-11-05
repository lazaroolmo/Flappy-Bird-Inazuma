using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GetComponent<PlayerInputController>().alive = false; // PARA QUE NO DEJE SALTAR
            GetComponent<Rigidbody>().isKinematic = true; // PARA QUE NO TENGA GRAVEDAD
            ProcessHit(); // LLAMA AL REINICIO DE NIVEL
        }
    }

    internal void ProcessHit()
    {
        LevelController levelController = FindAnyObjectByType<LevelController>();

        if(levelController != null)
        {
            levelController.TriggerReloadLevel();
        }
        else
        {
            Debug.LogError("No hay LevelController en la escena");
        }
    }
}
