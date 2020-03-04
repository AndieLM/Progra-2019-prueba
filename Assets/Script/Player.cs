using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float velocity = 25f;
    private Animator anim;
    private SpriteRenderer renderer;
    int HP = 20;
    private float canJump=25;
    public Rigidbody2D rb;
    public bool shoot = false;
    [Header("Flying Heart")]
    public GameObject flying_Heart;
    public Transform HeartSpawn;

    private void Awake()
    {

        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(30, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-30, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 25, 0);
        }
        if (Input.GetButton("Fire1"))
        {
            //creación del corazón instanciate
            Instantiate(flying_Heart, HeartSpawn.position,HeartSpawn.rotation);
            
        }
        shoot = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            canJump = 0;
        }
    }

}

