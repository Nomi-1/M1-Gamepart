using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    // Start is called before the first frame update
    // Add force nutzen
    List<Rigidbody> bricks = new List<Rigidbody>();

    void Start()
    {
        foreach (Rigidbody rb in GetComponentsInChildren<Rigidbody>()) { 
            bricks.Add(rb);
        }
    }

    // Update is called once per frame
    public void destroyCastle()
    {

        foreach (Rigidbody rb in bricks)
        {
            //Vector3 direction = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            Vector3 direction = new Vector3(rb.transform.position.x - transform.position.x, rb.transform.position.y - transform.position.y, rb.transform.position.z - transform.position.z);

            rb.isKinematic = false;
            rb.AddForce(direction * 500);
            Physics.IgnoreCollision(rb.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
