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
    [SerializeField]
    Spawn spawn;
   // int countDeadMonsters;
   // int test;

    // Start is called before the first frame update
    void Start()
    {
        displayLevel = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
        //test = spawn.countMosters;
    }

    public int current()
    {
        return displayLevel.text.Length;
    }

    public void decrease()
    {
        Debug.Log(spawn.countMosters);

        if (current() > 1)
        {
            displayLevel.text = displayLevel.text.Remove(displayLevel.text.Length - 1);
        }
        else {
            if (castle) {
                castle.destroyCastle();
              //  new WaitForSeconds(5);
               Application.Quit();
            }
            if (monster)
            {
                Destroy(transform.parent.gameObject);
               /* countDeadMonsters =- 1;
                if ((test - countDeadMonsters) == 0) {
                    Application.Quit();
                }
                Debug.Log(test + " Monsters " + (test - countDeadMonsters));*/
            }
        }
    }
}