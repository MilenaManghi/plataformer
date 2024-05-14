using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMira : Controller_Player
{
    public Transform miraArriba;
    public Transform miraIzquierda;
    public Transform miraDerecha;
    public Transform Mira;
    private ControllerDisparo controllerDisparo;


    private void Start()
    {
        controllerDisparo = GetComponent<ControllerDisparo>();
    }
   
    void Update()
    {
       if (GameManager.actualPlayer == playerNumber)
       {

            CambiarMira();
            controllerDisparo.Disparar();
       }
         
    }

    public void CambiarMira()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Mira.position = miraArriba.position;
            Mira.rotation = miraArriba.rotation;
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Mira.position = miraIzquierda.position;
            Mira.rotation = miraIzquierda.rotation;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Mira.position = miraDerecha.position;
            Mira.rotation = miraDerecha.rotation;
        }
    }
}
