using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        //TODO chceck if collisin is a player
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        FindObjectOfType<Counters>().AddApple(1);
        //TODO semd info to player
        //TODO check if inventory component exists
        Inventory inventory = collision.gameObject.GetComponent<Inventory>();
        //TODO destroy colletible
        Destroy(gameObject);




    }
    
}
