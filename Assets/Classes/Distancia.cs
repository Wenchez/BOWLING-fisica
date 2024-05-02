using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Distancia : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    private float distance;
    public TMP_Text distancetxt;

    // Start is called before the first frame update
    void Start()
    {
        SetDistance();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(obj1.transform.position,obj2.transform.position);
        SetDistance();
    }

    void SetDistance()
    {
        distancetxt.text = "Distancia: " + distance.ToString();
    }
}
