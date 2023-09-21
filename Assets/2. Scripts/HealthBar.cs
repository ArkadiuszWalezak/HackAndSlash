using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Image healthFill;
    [SerializeField] private Gradient gradient;
    [SerializeField] private Player player;
    [SerializeField] private HealthSystem health;

    
    private HealthSystem healthSystem;

    void Start()
    {
      
        healthSystem = GetComponent<HealthSystem>();

            healthBar.maxValue = health.Health;
            healthBar.value = health.Health;

            healthFill.color = gradient.Evaluate(1f);
        
    }

    void Update()
    {
        healthSystem = GetComponent<HealthSystem>();
       
            healthBar.value = health.Health;

            healthFill.color = gradient.Evaluate(healthBar.normalizedValue);
        
    }
}
