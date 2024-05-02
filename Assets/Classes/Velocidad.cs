using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtener la velocidad instantánea del objeto en cada dirección
        Vector3 velocidadInstantanea = rb.velocity;

        // Imprimir la velocidad en la consola
        Debug.Log("Velocidad instantánea: " + velocidadInstantanea);
    }
}
