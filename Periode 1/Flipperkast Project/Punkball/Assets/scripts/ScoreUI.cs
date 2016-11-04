using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {
    public int points;
    public Score scoreScript;
       
	// dit voegt punten toe als een object word geraakt door de ball
	void OnCollisionEnter (Collision x) {
        if(x.transform.tag == "Ball")
            scoreScript.ChangeScore(points);
	}

}
