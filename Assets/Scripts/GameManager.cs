using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int enemyEliminations = 0;
    public Text ScoreMeter;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void EliminateEnemy(int points)
    {
        enemyEliminations += points;
        ScoreMeter.text = "Score: " + enemyEliminations;
    }
}
