using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPortal : MonoBehaviour
{
    public bool activo;
    public GameObject Salida;

    void Start()
    {
        activo = false;
    }

   
    void Update()
    {
        if(activo == true)
        {
            Portal();
        }
    }

    public void Portal()
    {
       
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(activo == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.transform.position = Salida.transform.position; 
            }
        }
        if(activo == false)
        {
            if (collision.gameObject.CompareTag("Bala"))
            {
                activo = true;
            }
        }
   
    }


}
