using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right *(-speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);

        }
    }
}
