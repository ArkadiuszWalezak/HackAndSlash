using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    public Player Player { get { return player; } }
    private HealthSystem healthSystem;
    private KillsCounter killsCounter;

    void Start()
    {
        player = FindObjectOfType<Player>();
        healthSystem = GetComponent<HealthSystem>();
        killsCounter = GameObject.Find("KCO").GetComponent<KillsCounter>();

        healthSystem.OnDead += DestroyGameObject;
    }

    private void OnDestroy()
    {
        healthSystem.OnDead -= DestroyGameObject;
    }

    void Update()
    {
        
    }

    public void Hit(float value)
    {
        healthSystem.Hit(value);
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
        killsCounter.AddKill();
    }
}
