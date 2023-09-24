using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float strengh = 10;
    public float range = 5;
    private Player player;
    private HealthSystem healthSystem;
    private HealthBar healthBar;
    public GameObject body;
    public LivesCounter lives;
    public float timer = 5f;

    void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        healthBar = GetComponent<HealthBar>();
        lives = GetComponent<LivesCounter>();

        healthSystem.OnDead += HidePlayer;
        healthSystem.OnDead += StartRestarting;
        healthSystem.OnDead += GetComponent<PlayerMovement>().SetIfPlayerAlive;
    }

    private void OnDestroy()
    {
        healthSystem.OnDead -= HidePlayer;
        healthSystem.OnDead -= StartRestarting;
        healthSystem.OnDead -= GetComponent<PlayerMovement>().SetIfPlayerAlive;
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
        healthBar = GetComponent<HealthBar>();

        if (startRestartingScene)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void Hit(float value)
    {
        healthSystem.Hit(value);
    }

    public void HidePlayer()
    {
        body.gameObject.SetActive(false);
    }

    private bool startRestartingScene = false;

    public void StartRestarting()
    {
        startRestartingScene = true;
    }

    public void OneDeath()
    {
        lives.Death();
    }
}
