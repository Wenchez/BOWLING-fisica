using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aceleracion : MonoBehaviour
{
    public Vector3 aceleracion,fuerza,velocidad;
    public GameObject ball;
    public TMP_Text fuerzaTxt;
    public TMP_Text aceleracionTxt;
    public TMP_Text velocidadTxt;
    // Start is called before the first frame update
    void Start()
    {
        SetElementos();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fuerza = aceleracion * ball.GetComponent<Rigidbody>().mass;
        ball.GetComponent<Rigidbody>().AddForce(fuerza);
        velocidad = ball.GetComponent<Rigidbody>().velocity;
        SetElementos();
    }

    void SetElementos()
    {
        aceleracionTxt.text = "Aceleracion: " + aceleracion;
        fuerzaTxt.text = "Fuerza: " + fuerza;
        velocidadTxt.text = "Velocidad: "+velocidad;
    }
}
