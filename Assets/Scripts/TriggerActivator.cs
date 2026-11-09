using UnityEngine;

public class TriggerActivator : MonoBehaviour
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
        // SI EL QUE HA ACTIVADO EL TRIGGER ES EL PLAYER
        if(other.CompareTag("Player"))
        {
            // BUSCA EN EL PADRE LA VARIABLE A ACTIVAR
            GetComponentInParent<MovimientoRecto>().trigger_pasado = true;
        }
    }
}
