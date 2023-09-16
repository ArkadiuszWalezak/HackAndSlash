using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Enemy enemy;
    private float timer = 0;
    public float strengh = 10;

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, enemy.Player.transform.position) < 3)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                enemy.Player.Hit(strengh);
                timer = 1;
            }
        }
    }
}
