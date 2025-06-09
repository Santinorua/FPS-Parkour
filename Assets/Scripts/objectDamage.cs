using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDamage : MonoBehaviour
{
    
    HealthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name  == "Player")
        {
            
            healthManager.UpdateHealth(-5);
            
        }
    }
    
}
