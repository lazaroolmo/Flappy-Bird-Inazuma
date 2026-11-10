using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool jump, alive = true;
    [SerializeField] [Range (0 , 10000f)] float ThrustForce;
    [SerializeField] float speed = 5f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // DEJA EL Rigidbody DEL PLAYER COMO REFERENCIA
    }

    // Update is called once per frame
    void Update()
    {
        if(alive == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime); // MOVIMIENTO CONSTANTE
        }

        if (jump && alive == true)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Debug.Log("Saltando...");
        rb.AddRelativeForce(Vector3.up * ThrustForce * Time.fixedDeltaTime);
        jump = false; // INICIALIZO A 0
    }

    public void OnJump(InputValue value) // SE EJECUTA EN EL MOMENTO DE PRESIONAR EL BOTÓN
    {
        jump = value.isPressed;
    }

}
