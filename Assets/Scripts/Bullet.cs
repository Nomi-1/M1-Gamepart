using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial https://noobtuts.com/unity/tower-defense-game
 * The base structure is based on this source
 */


public class Bullet : MonoBehaviour
{
    // Speed
    public float speed = 10;

    // Target set by tower
    public Transform target;
    void FixedUpdate()
    {
        if (target)
        {
            // Fly towards the target
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else {
            // Otherwise destroy self
            Destroy(gameObject);
        }      
    }

    void OnTriggerEnter(Collider co) { 

        Health health = co.GetComponentInChildren<Health>();
        if (health) { 
            health.decrease();
            Destroy(gameObject);
        }
    }
}
