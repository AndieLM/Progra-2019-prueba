using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    public float velocity = 0.1f;
    private void Start()
    {
       
    }

 
    void Update()
    {
        gameObject.transform.position= new Vector3(gameObject.transform.position.x+velocity*Time.deltaTime, gameObject.transform.position.y, 0);
        float deltaPosition = velocity * Time.deltaTime;

    }
}
