using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Picked");
            hasPackage = true;
            Destroy(other.gameObject, 0.1f);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered");
            hasPackage = false;
        }    
    }

}
