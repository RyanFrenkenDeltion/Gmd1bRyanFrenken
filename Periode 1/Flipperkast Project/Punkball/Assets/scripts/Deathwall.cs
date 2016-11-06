using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Deathwall : MonoBehaviour {
    public AudioClip[] gameoversound;
    public int lifetaker = 3;
    public AudioClip lostBall;
	
    void OnTriggerEnter(Collider Other) {
        
            Destroy(Other.gameObject); //dit vernietigt alle objecten(De bal dus) die the deathwall aanraken, en haalt een levens punt eraf waneer hij getriggerd word.
            lifetaker += -1;
            AudioSource.PlayClipAtPoint(lostBall, transform.position);

        if (lifetaker == 0) //Waneer de levens punten op zijn, stopt hij met de achtergrond muziek en speelt hij de game over soundclip.
            {
                AudioSource.PlayClipAtPoint(gameoversound[0], transform.position);
                GameObject.Find("BackGroundMusic").GetComponent<AudioSource>().Stop();
            }
        

    }
}
