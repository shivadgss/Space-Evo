using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigShip : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 direction;
    public Transform CenterfirePoint;
    public Transform LeftFirePoint;
    public Transform RightFirePoint;
    public GameObject bulletPrefab;
    private float fireRate = 1f;
    private float nextFire = 0f;
    private float fireRate2 = 0.5f;
    public AudioClip Fireclip;
    public AudioClip Explosionclip;
    public AudioSource Source;
    public bool hasDied = false;

    //public Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //rb.position = playerPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(directionX, directionY).normalized;
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            Source.PlayOneShot(Fireclip);
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, CenterfirePoint.position, CenterfirePoint.rotation);
            Instantiate(bulletPrefab, LeftFirePoint.position, LeftFirePoint.rotation);
            Instantiate(bulletPrefab, RightFirePoint.position, RightFirePoint.rotation);

            if (ScoreScript.myScore >= 6000 && Input.GetKeyDown(KeyCode.E))
            {
                nextFire = Time.time + fireRate2;
            }

        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x, direction.y) * speed;
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Source.PlayOneShot(Explosionclip);
            Destroy(this.gameObject, 0.5f);
            anim.SetTrigger("bom");

            SceneManager.LoadScene(2);
        }
    }
}
