using UnityEngine;

/* 
 * NOTE: 
 * Since this was the first time I made game development I decided to start the game setup with
 * a Tutorial https://noobtuts.com/unity/tower-defense-game
 * The base structure is based on this source
 */

public class Health : MonoBehaviour
{
    TextMesh displayLevel;
    [SerializeField]
    Castle castle;
    [SerializeField]
    Monster monster;
    Spawn spawn;

    // Start is called before the first frame update
    void Start()
    {
        displayLevel = GetComponent<TextMesh>();
        spawn = FindObjectOfType<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }

    public int current()
    {
        return displayLevel.text.Length;
    }

    public void decrease()
    {
        if (current() > 1)
        {
            displayLevel.text = displayLevel.text.Remove(displayLevel.text.Length - 1);
        }
        else {
            if (castle) {
                castle.destroyCastle();
                new WaitForSeconds(5);
                Application.Quit();
            }
            if (monster)
            {
                Destroy(transform.parent.gameObject);
                spawn.countMosters--; // Track the monster in scene after some got destoried
                if (spawn.countMosters == 0) {
                    Application.Quit();
                }
            }
        }
    }
}