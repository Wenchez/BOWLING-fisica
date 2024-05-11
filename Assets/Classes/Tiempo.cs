using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tiempo : MonoBehaviour
{
    public GameObject bola,pino;
    public Vector3 posicionPino,posicionBola;
    [SerializeField] TextMeshProUGUI relogTxt;
    float lapsoTiempo;
    // Update is called once per frame
    void Start()
    {
        // Obtener el componente posicion del objeto
        posicionPino = pino.transform.position;
        posicionBola = bola.transform.position;
    }


    private bool relojActivo = true;

    void Update()
    {
        if (relojActivo && bola.transform.position != new Vector3(0f, 0.165f, 0f) && Time.deltaTime != 0.005 % 60f)
        {
            lapsoTiempo += Time.deltaTime;
            int seg = Mathf.FloorToInt(lapsoTiempo % 60);
            int mlseg = Mathf.FloorToInt((lapsoTiempo - Mathf.Floor(lapsoTiempo)) * 1000);
            relogTxt.text = string.Format("Tiempo:\n{0:00}:{1:00}", seg, mlseg);
        }
    }

    // Método para detener el reloj
    void DetenerReloj()
    {
        
    }
}
