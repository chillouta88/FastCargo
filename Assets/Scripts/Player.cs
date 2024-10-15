using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] float steerSpeed = 50f;
    [SerializeField] float moveSpeed = 40f;
    [SerializeField] float slowSpeed = 25f;
    [SerializeField] float crashSpeed = 0f;
    [SerializeField] float boostSpeed = 45f;


    void Start()
    {
        
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);    
        transform.Translate(0,moveAmount,0);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = crashSpeed;    
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Barier")
        {
            moveSpeed = slowSpeed;
        }

        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;    
        }    
    }

        
       
}
