using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 velocidad;
    public GameObject bola;
    public TMP_Text velocidadTxt;

    void Start()
    {
    }

    void Update()
    {
        velocidad = bola.GetComponent<Rigidbody>().velocity;
        velocidadTxt.text = "Velocidad: " + velocidad;
    }
}
