using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [Header("Health Settings")]
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private float healthRegenPerSecond;

    [Header("Shield Settings")]
    [SerializeField] private float maxShield; // if - no cap
    [SerializeField] private float currentShield;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Die() 
    {
        // death animation
        Destroy(gameObject);
    }
    public void TakeDamage(float damage) 
    {
        if (damage <= currentShield)
        {
            currentShield -= damage;
            return;
        }

        currentHealth -= damage - currentShield;

        currentShield = 0;

        if (currentHealth <= 0) { Die(); }
    }
    public void RegenHealth(float regenHealth) 
    {
        if (currentHealth + regenHealth < maxHealth)
        {
            currentHealth += regenHealth;
            return;
        }

        currentHealth = maxShield;
    }
    public void RegenShield(float regenShield)
    {
        if (currentShield + regenShield < maxShield || maxShield < 0) // if maxShield is -, inf shield cap
        {
            currentShield += regenShield;
            return;
        }

        currentShield = maxShield;
    }
    private void Update()
    {
        RegenHealth(healthRegenPerSecond * Time.deltaTime);
    }
}
