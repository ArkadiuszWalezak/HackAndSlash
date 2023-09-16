using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float strengh = 10;
    public float range = 5;
    private Player player;
    private HealthSystem healthSystem;

    void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collider[] enemies = Physics.OverlapSphere(transform.position, range);
            foreach (Collider enemy in enemies)
            {
                if (enemy.GetComponent<Enemy>() != null)
                {
                    enemy.GetComponent<Enemy>().Hit(strengh);
                }
            }
        }
    }

    public void Hit(float value)
    {
        healthSystem.Hit(value);
    }
}
