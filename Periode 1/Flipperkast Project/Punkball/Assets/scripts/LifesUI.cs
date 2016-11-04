using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifesUI : MonoBehaviour {
    public int points;
    

	
    void OnTriggerEnter() //dit haalt levens punten af waneer de Deathwall word getriggerd.
    {
        GameObject.Find("Deathwall").GetComponent<Lifestext>().ChangeScore(points); 
    }

}
