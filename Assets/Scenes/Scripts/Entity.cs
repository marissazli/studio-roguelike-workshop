using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using Unity.VisualScripting;

public class Entity : MonoBehaviour
{
    [NonSerialized]
    public float CurrentHealth;
    bool dead = false;

    [Serializable]
    public struct EntityStats
    {
        public float MaxHealth;
        public float MovementSpeed;
    }

    private void Start()
    {
        CurrentHealth = stats.MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (dead) return;

        CurrentHealth -= Mathf.Ceil(damage);

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        dead = true;
        Destroy(gameObject);
    }

    public EntityStats stats;

}