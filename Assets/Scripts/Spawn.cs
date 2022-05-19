using UnityEngine;


/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial https://noobtuts.com/unity/tower-defense-game
 * The base structure is based on this source
 */

public class Spawn : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float interval = 3;
    public int countMosters = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }
    void SpawnNext()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
        countMosters++; // Count the total number of monsters
    }
}
