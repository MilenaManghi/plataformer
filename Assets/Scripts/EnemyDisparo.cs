using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisparo : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float TimeTotal;
    private float ActualTime = 0;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if(ActualTime >= TimeTotal)
        {
          Disparar();
            ActualTime = 0;
        }
        else
        {
            ActualTime += Time.deltaTime; 
        }
       
    }

    private void Disparar()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
