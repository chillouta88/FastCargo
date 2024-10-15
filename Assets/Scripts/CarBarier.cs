using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBarier : MonoBehaviour
{
    [SerializeField] float carMoveSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float speedAmount = carMoveSpeed * Time.deltaTime;
       transform.Translate(0,speedAmount,0); 
    }
}
