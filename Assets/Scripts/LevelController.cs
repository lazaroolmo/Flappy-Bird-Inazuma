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
        if (isReload)
        {
            isReload = false;
            Invoke("ReloadLevel", reloadLapseTime);
        }
    }

    public void TriggerReloadLevel()
    {
        isReload = true;
    }

    public void LoadNextLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((CurrentScene + 1) % SceneManager.sceneCountInBuildSettings) ;
    }
    public void ReloadLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
    }
}
