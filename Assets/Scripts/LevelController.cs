using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    bool isReload = false;
    float reloadLapseTime = 1f; // TIEMPO DE ESPERA ANTES DE REINICIAR 1s
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isReload) // SI SE LLAMA AL REINICIO
        {
            isReload = false;
            Invoke("ReloadLevel", reloadLapseTime); // EJECUTA ReloadLevel UNA VEZ PASADO reloadLapseTime
        }
    }

    public void TriggerReloadLevel() // LLAMA AL REINICIO CON UNA COLISIÓN
    {
        isReload = true;
    }

    public void LoadNextLevel() // PASARSE EL NIVEL
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex; // EXTRAE EL ÍNDICE DE LA ESCENA ACTUAL
        SceneManager.LoadScene((CurrentScene + 1) % SceneManager.sceneCountInBuildSettings); // CARGA LA SIGUIENTE ESCENA DIVIDIENDO ENTRE EL TOTAL
    }
    public void ReloadLevel() // REINICIAR EL NIVEL
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene); // CARGA LA MISMA ESCENA
    }
}
