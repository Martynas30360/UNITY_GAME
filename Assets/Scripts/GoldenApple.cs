using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenApple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        //TODO chceck if collisin is a player
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
       

        if (!collision.gameObject.CompareTag("Potion"))
        {
            FindObjectOfType<Counters>().Heal(30f);
            Destroy(gameObject);
        }

    }
}
