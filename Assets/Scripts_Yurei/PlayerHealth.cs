using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth = 10f;
    public TMP_Text HealthText;

    private void Start()
    {
        CurrentHealth = MaxHealth;
        HealthText.text = $"{CurrentHealth} / {MaxHealth}";
    }

    public void ChangeHealthPlayer(float amount)
    {
        CurrentHealth += amount;
        HealthText.text = $"{CurrentHealth} / {MaxHealth}";
        Debug.Log($"Current Health : {CurrentHealth}");

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