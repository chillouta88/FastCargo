using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour

{
   [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float steerSpeed = 0.1f;    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
       transform.Translate(0, moveAmount, 0);
       transform.Rotate(0, 0, -steerAmount);       
    }
}
