﻿using UnityEngine;
using System.Collections;

public class BaseCharacter : PoolObject
{

    protected float fHealth;
    protected float fMaxHealth = 100f;
    protected bool bIsDead = false;

    virtual protected void Start()
    {
	    //Base
        fHealth = fMaxHealth;
    }

    virtual protected void Update()
    {
	    //Base
    }

    /// <summary>
    /// Calculates the health.
    /// </summary>
    /// <param name="deltaHealth">Delta health.</param>
    virtual public void CalculateHealth(float deltaHealth)
    {
        fHealth += deltaHealth;
        if (fHealth > fMaxHealth)
        {
            fHealth = fMaxHealth;
        }
        CalculateDead();
    }

    private void CalculateDead()
    {
        if (fHealth <= 0)
        {
            bIsDead = true;
        }
        else
        {
            bIsDead = false;
        }
    }

    /// <summary>
    /// Determines whether this instance is dead.
    /// </summary>
    /// <returns><c>true</c> if this instance is dead; otherwise, <c>false</c>.</returns>
    public bool IsDead()
    {
        return bIsDead;
    }

    /// <summary>
    /// Gets the health.
    /// </summary>
    /// <returns>The health.</returns>
    public float GetHealth()
    {
        return fHealth;
    }

    public float GetMaxHealth()
    {
        return fMaxHealth;
    }
}