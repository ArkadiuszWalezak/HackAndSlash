using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private float health;

    void Start()
    {
        health = 100;
    }

    public void Hit(float value)
    {
        health -= value;

        if (health <= 0)
        {
            Die();
            return;
        }

        Debug.Log(health);
    }

    private void Die()
    {
        Debug.Log("dead");
        Destroy(gameObject);
    }
}
