using UnityEngine;

/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial https://noobtuts.com/unity/tower-defense-game
 * The base structure is based on this source
 * 
 * Further sources: https://gamedevplanet.com/2-simple-ways-to-change-color-of-a-3d-object-in-unity/
 */

public class Buildplace : MonoBehaviour
{
    // Tower building
    public GameObject towerPrefab;
    public int maxTowers = int.MaxValue;
    static int currentTowers = 0;

    public void OnMouseUp()
    {
        if (currentTowers < maxTowers) { 
            // Tower above the buildplace
            GameObject g = (GameObject) Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
            currentTowers++;
        }
    }
}
