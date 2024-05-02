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
        // Obtener la velocidad instant�nea del objeto en cada direcci�n
        Vector3 velocidadInstantanea = rb.velocity;

        // Imprimir la velocidad en la consola
        Debug.Log("Velocidad instant�nea: " + velocidadInstantanea);
    }
}
