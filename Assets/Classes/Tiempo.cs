using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tiempo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI relogTxt;
    float lapsoTiempo;
    // Update is called once per frame
    void Update()
    {
        lapsoTiempo += Time.deltaTime;
        int seg = Mathf.FloorToInt(lapsoTiempo % 60);
        int mlseg = Mathf.FloorToInt((lapsoTiempo - Mathf.Floor(lapsoTiempo)) * 1000);
        relogTxt.text = string.Format("Tiempo:\n{0:00}:{1:00}", seg, mlseg);
    }
}
