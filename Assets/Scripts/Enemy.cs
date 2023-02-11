using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;
    Rigidbody2D rb;
    private float speed = 5f;
    public GameObject enemyBullet;
    public Transform firePoint;
    private float timer;
    public AudioClip Fireclip;
    public AudioClip ExplosionClip;
    public AudioSource Source;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Source.PlayOneShot(ExplosionClip);   
            anim.SetTrigger("boom");
            Destroy(other.gameObject);
            Destroy(this.gameObject,0.5f);
            ScoreScript.myScore += 100;
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        rb.velocity = transform.up*(-speed);
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            Shoot();
        }
    }
    void Shoot()
    {
        Source.PlayOneShot(Fireclip);
        Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
    }
}
