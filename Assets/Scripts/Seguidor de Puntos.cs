using UnityEngine;

public class SeguidordePuntos : MonoBehaviour
{
    public static SeguidordePuntos Instancia;

    public int puntos_actuales;
    public int puntos_guardados; // CHECKPOINT
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            puntos_actuales = 0;
            puntos_guardados = 0;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConfirmarPuntos()
    {
        puntos_guardados = puntos_actuales; 
    }

    public void IrAlCheckpoint()
    {
        puntos_actuales = puntos_guardados;
    }
}
