using UnityEngine;

public class Tiritar : MonoBehaviour
{
    [SerializeField] float speed = 50f; // VELOCIDAD DE VIBRACIÓN
    [SerializeField] float fuerza = 0.1f; // ESPACIO QUE SE DESPLAZA AL VIBRAR
    public bool trigger_pasado = false;

    private Vector3 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger_pasado == true)
        {
            float temblor = Mathf.Sin(Time.time * speed) * fuerza; // CALCULA EL TEMBLOR
            transform.position = posicionInicial + new Vector3(temblor, 0, 0); // APLICA EL TEMBLOR
        }
    }
}
