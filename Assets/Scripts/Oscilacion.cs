using System;
using UnityEngine;

public class Oscilacion : MonoBehaviour
{
    [SerializeField] float velocidad = 3f;
    [SerializeField] float fuerza = 3f;
    [SerializeField] float desfase = 3f;
    private Vector3 posicionInicial;
    public bool alive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive) // PARA EVITAR OSCILACIÓN AL MORIR
        {
            float movimiento = Mathf.Sin((Time.time * velocidad + desfase) * fuerza); // VARIABLE SENO
            transform.position = posicionInicial + new Vector3(0 , movimiento , 0); // MUEVE EN EL EJE Y
        }

    }
}
