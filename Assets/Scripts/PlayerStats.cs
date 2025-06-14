using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private float maxHealth = 100;
   [SerializeField] private float health = 100;
    public Animator anim;
    public GameObject gameOverPanel;

    public bool isDead = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float demage)
    {
       demage = Mathf.Abs(demage);
       health = Mathf.Clamp(health - demage, 0, maxHealth);

        //if healt-demage > maxHealth =>maxHealth
        // if health-damage < 0 => 0
        CheckHealth();

   


    }
    public void Heal(float heal)
    {
        heal = Mathf.Abs(heal);
        health = Mathf.Clamp(health + heal, 0, maxHealth);
        CheckHealth();
    }
    public void CheckHealth()
    {
        if (health == 0)
        {
            anim.SetTrigger("isDead");
            isDead = true;
            gameOverPanel.SetActive(true);
            Invoke(nameof(ReloadScene), 2);
        }
    }
        private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public IEnumerator FlashSprite(float duration, float flashInterval)
    {
        float elapsedTime = 0f;
        bool isVisible = true;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        while (elapsedTime < duration)
        {
            isVisible = !isVisible;
            sr.enabled = isVisible;

            yield return new WaitForSeconds(flashInterval);
            elapsedTime += flashInterval;
        }

        sr.enabled = true; 
    }



}
