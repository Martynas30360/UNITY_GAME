using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counters : MonoBehaviour
{
    public TMP_Text appleText; // albo TMP_Text, jeœli u¿ywasz TextMeshPro
    public Image healthBar;

    private int appleCount = 0;
    private float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateAppleText();
        UpdateHealthBar();
    }

    public void AddApple(int amount)
    {
        appleCount += amount;
        UpdateAppleText();
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
        UpdateHealthBar();
    }

    void UpdateAppleText()
    {
        appleText.text = "Apples: " + appleCount.ToString();
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}

