using UnityEngine;

public class TriggerActivatorMountain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // PARA QUE TIEMBLE AL ENTRAR AL TRIGGER
    {
        // SI EL QUE HA ACTIVADO EL TRIGGER ES EL PLAYER
        if(other.CompareTag("Player"))
        {
            // BUSCA EN EL PADRE LA VARIABLE A ACTIVAR
            GetComponentInParent<Tiritar>().trigger_pasado = true;
        }
    }

    private void OnTriggerExit(Collider other) // PARA QUE DEJE DE TEMBLAR AL SALIR DEL TRIGGER
    {
        if (other.CompareTag("Player"))
        {
            GetComponentInParent<Tiritar>().trigger_pasado = false;
        }
    }
}
