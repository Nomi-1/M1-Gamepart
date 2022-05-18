using UnityEngine;

/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial https://noobtuts.com/unity/tower-defense-game
 * The base structure is based on this source
 */

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float rotationSpeed = 35;

    private void OnTriggerEnter(Collider co)
    {
        if (co.GetComponent<Monster>()) {
            GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }
}