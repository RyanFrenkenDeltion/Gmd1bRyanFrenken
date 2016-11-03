using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoretext;
    int score;
	
    public void ChangeScore(int points) {
        print(points);
        score += points;
        scoretext.text = "Score: " + score;
	}
	
	
	void Update () {
	
	}
}
