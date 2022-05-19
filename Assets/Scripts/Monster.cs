using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial 
 * The base structure is based on this source
 */

public class Monster : MonoBehaviour
{
    void Start()
    {
        
        GameObject castle = GameObject.Find("Castle");
        if (castle)
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = castle.transform.position;

    }

    void OnTriggerEnter(Collider co)
    {
        if (co.name == "Castle")
           {
             co.GetComponentInChildren<Health>().decrease();
             Destroy(gameObject);
        }
        
    }
}