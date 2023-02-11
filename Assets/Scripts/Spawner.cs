using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawnPoint;

    private int randEnemy;
    private int randPosition;

    public float StartTime;
    private float TimeBtwSpwn;

    private void Start()
    {
        TimeBtwSpwn = StartTime;
    }

    private void Update()
    {

        if (ScoreScript.myScore > 500)
        {
            StartTime = 4f;
        }

        if (ScoreScript.myScore > 1000)
        {
            StartTime = 3f;
        }

        if (ScoreScript.myScore > 1500)
        {
            StartTime = 2.5f;
        }

        if (ScoreScript.myScore > 2000)
        {
            StartTime = 2f;
        }

        if (ScoreScript.myScore > 3000)
        {
            StartTime = 1.9f;
        }

        if (ScoreScript.myScore > 3500)
        {
            StartTime = 1.8f;
        }

        if (ScoreScript.myScore > 4000)
        {
            StartTime = 1.7f;
        }

        if (ScoreScript.myScore > 5000)
        {
            StartTime = 1.6f;
        }

        if (ScoreScript.myScore > 6000)
        {
            StartTime = 1.5f;
        }


        if (TimeBtwSpwn <= 0)
        {
            randEnemy = Random.Range(0, enemies.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(enemies[randEnemy], spawnPoint[randPosition].position,Quaternion.Euler(0,0,-90));
            TimeBtwSpwn = StartTime;
        }
        else
        {
            TimeBtwSpwn -= Time.deltaTime;
        }
    }
}
