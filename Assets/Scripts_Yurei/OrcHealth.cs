using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcHealth : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth = 1f;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void ChangeHealthOrc(float amount)
    {
        CurrentHealth += amount;

        if (CurrentHealth > MaxHealth) 
        {
            CurrentHealth = MaxHealth;
        }

        if (CurrentHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
