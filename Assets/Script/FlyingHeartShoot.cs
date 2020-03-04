using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingHeartShoot : MonoBehaviour
{
    public Rigidbody2D FlyingHeart;
    public float speed = 20;
    public bool shoot = false;
    void Start()
    {
        
    }
    void flyingHeartShoot()
    {
        Rigidbody2D FlyingHeartClone = (Rigidbody2D)Instantiate(FlyingHeart, transform.position, transform.rotation);
        FlyingHeartClone.velocity = transform.forward * speed;
    }

    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            //creación del corazón instanciate
            Instantiate(flying_Heart, HeartSpawn.position);
            shoot = true;
        }*/
    }
}
