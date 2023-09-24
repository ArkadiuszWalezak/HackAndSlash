using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class HealthSystem : MonoBehaviour
{
    public Action OnDead;
    private LivesCounter howManyLivesLeft;

    public float Health { get => health;}
    private float health = 100;

    void Start()
    {
        howManyLivesLeft = GetComponent<LivesCounter>();
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

    public void Die()
    {
        //if (howManyLivesLeft.ReturnLives() == 0)
        //{
        //    howManyLivesLeft.GameOver();
        //}
        //else
        //{
           ;
            Debug.Log("dead");
            OnDead?.Invoke();
        //}
    }
}
