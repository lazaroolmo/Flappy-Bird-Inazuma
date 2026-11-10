using UnityEngine;

public class MovimientoRecto : MonoBehaviour
{
     [SerializeField] float speed = 3f;
     public bool trigger_pasado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger_pasado == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime); // MOVIMIENTO HACIA ARRIBA
        }
    }
}
