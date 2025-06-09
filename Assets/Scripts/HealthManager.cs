using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public UIManager uiManager;
    public int health;

    public void UpdateHealth(int difference)
    {
        health += difference;
        if (health < 0)
        {
            health = 0;
            Debug.Log("Game Over");
            return;
        }
        else if (health > 100)
        {
            health = 100;
        }
        uiManager.UpdateHealthText(health.ToString());

    }
}
