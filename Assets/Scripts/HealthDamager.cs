using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class HealthDamager : MonoBehaviour
{

    public float damage = 40;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject collisionobject = collision.gameObject;
        HandleTakeDamage(collisionobject);
       
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionobject = collision.gameObject;
        HandleTakeDamage(collisionobject);
    }

    private void HandleTakeDamage(GameObject collisionobject)
    {
        if (!collisionobject.CompareTag("Player"))
        {
            return;
        }

        PlayerStats stats = collisionobject.GetComponent<PlayerStats>();

        if (stats == null)
        {
            return;
        }

        stats.TakeDamage(damage);

    }
}
