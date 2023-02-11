using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);

        }
    }
}
