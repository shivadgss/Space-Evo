using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Animator anim;
    public Transform CenterfirePoint;
    public Transform LeftFirePoint;
    public Transform RightFirePoint;
    public GameObject bulletPrefab;
    private float fireRate = 1f;
    private float nextFire = 0f;
    public AudioClip Fireclip;
    public AudioClip Explosionclip;
    public AudioSource Source;
    public GameObject ship1;
    public GameObject ship2;
    public Transform s2;
    public bool db_up = false;
    public bool tb_up = false;
    public bool ship_up = false;
    public bool fr_up = false;
    public bool hasDied = false;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ship1.gameObject.SetActive(true);
        ship2.gameObject.SetActive(false);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //movement
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(directionX, directionY).normalized;

        //checking upgrades
        CHeckUp();

        
        //Shooting
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            Source.PlayOneShot(Fireclip);
            nextFire = Time.time + fireRate;
           
            if (db_up && !tb_up)
            {
                Instantiate(bulletPrefab, LeftFirePoint.position, LeftFirePoint.rotation);
                Instantiate(bulletPrefab, RightFirePoint.position, RightFirePoint.rotation);
            } 
            
            else if (tb_up)
            {
                
                Instantiate(bulletPrefab, CenterfirePoint.position, CenterfirePoint.rotation);
                Instantiate(bulletPrefab, RightFirePoint.position, RightFirePoint.rotation);
                Instantiate(bulletPrefab, LeftFirePoint.position, LeftFirePoint.rotation);
            }
            else
            {
                Instantiate(bulletPrefab, CenterfirePoint.position, CenterfirePoint.rotation);
            }

        }


        //ship upgrade
        if (ship_up)
        {
            ship2.gameObject.SetActive(true);
            ship1.gameObject.SetActive(false);
        }



        //updating postitions of second ship
        s2.position = rb.position;
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
            Destroy(this.gameObject,0.5f);
            anim.SetTrigger("booom");

            SceneManager.LoadScene(2);

        }
    }

    public void CHeckUp()
    {
        if (ScoreScript.myScore > 500 && Input.GetKeyDown(KeyCode.E))
        {
            db_up = true;
        }
        
        if (ScoreScript.myScore > 1500 && Input.GetKeyDown(KeyCode.E))
        {
            tb_up = true;
            
        }
        
        if (ScoreScript.myScore > 3000 && Input.GetKeyDown(KeyCode.E))
        {
            ship_up = true;
        }
        
        if (ScoreScript.myScore > 6000 && Input.GetKeyDown(KeyCode.E))
        {
            fr_up = true;
        }

        

    }
}
