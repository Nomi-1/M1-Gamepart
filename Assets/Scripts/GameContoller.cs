using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    GameObject[] game;
    [SerializeField]
    Buildplace[] buildplace;

    public void startGame(int gameMode) {
        canvas.gameObject.SetActive(false);
        foreach (GameObject go in game) {
            go.SetActive(true);
        }
        foreach (Buildplace b in buildplace) { 
            if (gameMode == 0) {
                b.maxTowers = 4;
            }
        if (gameMode == 1)
        {
            b.maxTowers = 2;
        }
        if (gameMode == 2)
        {
            b.maxTowers = 1;
        }
    }
    }
}
