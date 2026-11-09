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
            GetComponent<PlayerInputController>().alive = false; // PARA QUE NO DEJE SALTAR EL PLAYER

            GetComponent<Rigidbody>().isKinematic = true; // PARA QUE NO TENGA GRAVEDAD EL PLAYER
            
            // PARA QUE LAS ESFERAS DEJEN DE MOVERSE
            MovimientoRecto movimiento_esferas = collision.gameObject.GetComponentInParent<MovimientoRecto>(); // BUSCA EL SCRIPT DEL OBJETO CHOCADO
            if (movimiento_esferas != null)
            {
                movimiento_esferas.trigger_pasado = false; // ACTÚA SÓLO SI EL OBJETO TIENE EL SCRIPT (SI ES UNA ESFERA)
            }

            // PARA QUE LA MONTAÑA DEJE DE MOVERSE
            Tiritar movimiento_montaña = collision.gameObject.GetComponentInParent<Tiritar>(); // BUSCA EL SCRIPT DEL OBJETO CHOCADO
            if (movimiento_montaña != null)
            {
                movimiento_montaña.trigger_pasado = false; // ACTÚA SÓLO SI EL OBJETO TIENE EL SCRIPT (SI ES UNA MONTAÑA)
            }

            // PARA QUE LAS CÁPSULAS DEJEN DE MOVERSE
            Oscilacion movimiento_capsulas = collision.gameObject.GetComponentInParent<Oscilacion>(); // BUSCA EL SCRIPT DEL OBJETO CHOCADO
            if (movimiento_capsulas != null)
            {
                movimiento_capsulas.alive = false; // ACTÚA SÓLO SI EL OBJETO TIENE EL SCRIPT (SI ES UNA CÁPSULA)
            }

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
