
using System;
using UnityEngine;
using TMPro;

public class HealthObject : MonoBehaviour
{

    [SerializeField] int maxHealth = 100;
    [SerializeField] TMP_Text textComponent;

    [SerializeField] GameObject objectTurnOn;

    [SerializeField] Color maxHealthColor;
    [SerializeField] Color zeroHealthColor;

    int currentHealth;

    const string healthKey = "health";

    private void OnDestroy()
    {
        PlayerPrefs.SetInt(healthKey, currentHealth);



    }

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey(healthKey))
        {

            currentHealth = PlayerPrefs.GetInt(healthKey);


        }
        if (currentHealth == 0)
        {

            currentHealth = maxHealth;

        }

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
        TestDeath();

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
        TestDeath();
    }

    void TestDeath()
    {

        if (isDead())
        {

            objectTurnOn?.SetActive(true); //a kérdõjel azt jelenti, hogy ha esetleg null, azaz valami feleslegesen hívja, akkor nem fut le.

        }

    }
}
