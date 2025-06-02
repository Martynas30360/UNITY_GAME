using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private float maxHealth = 100;
   [SerializeField] private float health = 100;
    public Animator anim;

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
        }
    }
}
