using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {
    public int points;
    public Score scoreScript;
       
	// Use this for initialization
	void OnCollisionEnter (Collision x) {
        if(x.transform.tag == "Ball")
            scoreScript.ChangeScore(points);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
