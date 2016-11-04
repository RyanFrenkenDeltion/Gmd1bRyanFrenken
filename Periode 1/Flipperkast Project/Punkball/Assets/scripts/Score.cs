using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoretext;
    int score;
	
    public void ChangeScore(int points) {  //dit laat de score op het scherm zien in playmode.
        print(points);
        score += points;
        scoretext.text = "Score: " + score;
	}
	
	
}
