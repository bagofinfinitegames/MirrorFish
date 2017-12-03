using UnityEngine;

public class GameManager : MonoBehaviour {

    public int points = 0;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void addPoints(int point)
    {
        points += point;
    }
}
