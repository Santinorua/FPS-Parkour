﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject); 
        if(collision.gameObject.name == "Player")
        {
            if (moneyManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
            
        }
    }
}
