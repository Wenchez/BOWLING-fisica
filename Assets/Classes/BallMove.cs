using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    public List<KeyCode> direccionales;
    public Vector3 movida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(direccionales[0]))
        {
            movida = new Vector3(0, 0, 0.01f);
        }
        else if (Input.GetKeyDown(direccionales[1]))
        {
            movida = new Vector3(0, 0, -0.01f);
        }

        if (Input.GetKeyUp(direccionales[0]) || Input.GetKeyUp(direccionales[1]))
        {
            movida = new Vector3();
        }

        transform.position += movida;

        if (Input.GetKeyDown(direccionales[2]))
        {
            transform.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, -100));
        }

    }
}
