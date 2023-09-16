using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> spawnpoints = new List<Transform>();
    public Enemy enemy;

    void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(enemy, spawnpoints[UnityEngine.Random.Range(0,spawnpoints.Count)]);
    }
}
