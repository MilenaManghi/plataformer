using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBotton : MonoBehaviour
{
    public GameObject Puerta;
    public GameObject Puerta2;
    private Rigidbody rb;
    

    public bool Open;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Open == true)
        {
            Puerta.SetActive(false);
            Puerta2.SetActive(false);
        }
        if(Open==false)
        {
            Puerta.SetActive(true);
            Puerta2.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            if(Open == false)
            {
                Open = true;
                
            }
            else if (Open == true)
            {
                Open = false;
            }
        }
    }


}
