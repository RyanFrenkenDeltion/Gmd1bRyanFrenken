using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lifestext : MonoBehaviour {
    public string lifeDisplayText;
    public Text lifestext;
	

	public void ChangeScore(int points) { //dit veranderd de zichtbare score in the playmode

        
        lifestext.text = lifeDisplayText + GameObject.Find("Deathwall").GetComponent<Deathwall>().lifetaker.ToString();
	}
	
}
