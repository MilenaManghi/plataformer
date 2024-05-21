using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBullet : MonoBehaviour
{
    public float life = 3;
    public GameObject Portal;

  

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Lunar")
        {
            var portal = Instantiate(Portal);
            Destroy(this.gameObject);
        }
    }





    
   
}
