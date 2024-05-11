using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Aceleracion : MonoBehaviour
{
    //El codigo funciona de manera muy irregular, hay veces cuando le tienes que picar varias veces a la barra para que funcione el disparo correctamente, no se porque
    //Aunque eso no este arreglado aun falta la funcion para que cada vez que se disparen los bolos estos se reinicien, sin contar que tambien se ocupa otro scrpit para una pantalla con la puntuacion del jugador
    //Tambien falta el poder acomodar la bola antes de disparar, y posiblemente agregar una especie de indicador para apuntar la bola, pero eso despues.
    public Vector3 aceleracion, fuerza;
    public float force;


    //Objetos del juego
    public GameObject ball;
    public TMP_Text fuerzaTxt;
    public TMP_Text aceleracionTxt;
    //La barrita
    public Slider forceUI;
    // El start es practicamente inecesario pero pues lo agrego porque no pasa nada, al princpio todos los valores son 0
    void Start()
    {
        SetElementos();
    }

    // La diferencia entre Update y FixedUpdate no la conozco, pero el codigo funciona mucho mejor si usas FixedUpdate, hace lo mismo de estarse ejecutando cada frame
    void FixedUpdate()
    {
        //Si presionas espacio se comienza a cargar la barra
        if(Input.GetKey(KeyCode.Space))
        {
            slider();
        }
        //Cuando la sueltas se acciona el disparo
        if(Input.GetKeyUp(KeyCode.Space))
        {
            disparo();
        }
        //Para este punto la fuerza ya se debio de haber asignado en el metodo disparo y entonces se utiliza la funcion AddForce para que el rigidbody de la bola comience a agregarse esa fuerza
        ball.GetComponent<Rigidbody>().AddForce(fuerza);
        SetElementos();
    }

    //Los componentes de los vectores se ponen en las ventanas de texto cada frame
    void SetElementos()
    {
        aceleracionTxt.text = "Aceleracion: " + aceleracion;
        fuerzaTxt.text = "Fuerza: " + fuerza;
    }
    //Se agrega el valor en force hacia el componente en x del vector fuerza para que la fuerza sea en direccion recta hacia enfrente siempre y 9.8 para contrarrestar la aceleracion de la gravedad, no hay pedo si juegas con los valores, aunque los bases suelen ser estos
    void disparo()
    {
        fuerza = new Vector3(force, 9.8f, 0f);
        aceleracion = fuerza / ball.GetComponent<Rigidbody>().mass;
    }
    //Cada frame que se mantenga pulsado el espacio se supone que se incrementa el valor de force y se utiliza el mismo valor para actualizar la barra y se vea que sube
    void slider()
    {
        force++;
        forceUI.value = force;
    }
}
