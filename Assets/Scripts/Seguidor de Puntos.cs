using UnityEngine;

public class SeguidordePuntos : MonoBehaviour
{
    public static SeguidordePuntos Instancia; // SE PUEDE ACCEDER SIN HACER GetComponent()

    public int puntos_actuales;
    public int puntos_guardados; // CHECKPOINT

    // PATRÓN SINGLETON
    void Awake() // VA ANTES QUE TODOS LOS Start
    {
        if (Instancia == null) // SI NO HAY MANAGER DE SEGUIDOR PUNTOS (PERSISTENCIA)
        {
            Instancia = this; // ESTE SCRIPT SERÁ EL MANAGER
            puntos_actuales = 0;
            puntos_guardados = 0;
            DontDestroyOnLoad(gameObject); // NO DESTRUIR EL OBJETO, ASÍ SE GUARDAN LOS PUNTOS
        }
        else
        {
            Destroy(gameObject); // POR SEGURIDAD
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConfirmarPuntos() // ACTUALIZA EL CHECKPOINT
    {
        puntos_guardados = puntos_actuales; 
    }

    public void IrAlCheckpoint() // REGRESA AL CHECKPOINT
    {
        puntos_actuales = puntos_guardados;
    }
}
