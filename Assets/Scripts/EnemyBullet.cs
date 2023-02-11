using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform firePoint;
    private float timer;


    private void Update()
    {
        timer+=Time.deltaTime;
        if(timer > 1)
        {
            timer=0;
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(enemyBullet,firePoint.position, firePoint.rotation);
    }
}
