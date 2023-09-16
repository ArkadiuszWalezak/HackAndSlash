using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    public Player Player { get { return player; } }

    private HealthSystem healthSystem;

    void Start()
    {
        player = FindObjectOfType<Player>();
        healthSystem = GetComponent<HealthSystem>();
    }

    void Update()
    {
        
    }

    public void Hit(float value)
    {
        healthSystem.Hit(value);
    }
}
