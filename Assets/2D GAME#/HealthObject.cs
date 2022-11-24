
using System;
using UnityEngine;
using TMPro;

public class HealthObject : MonoBehaviour
{

    [SerializeField] int maxHealth = 100;
    [SerializeField] TMP_Text textComponent;

    [SerializeField] Color maxHealthColor;
    [SerializeField] Color zeroHealthColor;


    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;

        UpdateText();
    }

    void UpdateText()
    {
        textComponent.text = "Health" + currentHealth;

        float healthRate = (float)currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthRate);
    }

    public void Kill()
    {

        currentHealth = 0;
        UpdateText();

    }

    public bool isDead()
    {

        return currentHealth <= 0;


    }

    public void Damage(int demage)
    {
        currentHealth = currentHealth - 10;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateText();
    }
}
