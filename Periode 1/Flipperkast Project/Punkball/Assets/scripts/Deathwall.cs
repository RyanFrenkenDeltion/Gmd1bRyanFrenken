using UnityEngine;
using System.Collections;

public class Deathwall : MonoBehaviour {
    public AudioClip[] gameoversound;
    public int lifetaker = 3;
	
    void OnTriggerEnter(Collider Other) {
        {
            Destroy(Other.gameObject);
            lifetaker += -1;

            if (lifetaker == 0)
            {
                AudioSource.PlayClipAtPoint(gameoversound[0], transform.position);
                GameObject.Find("BackGroundMusic").GetComponent<AudioSource>().Stop();
            }
        }

    }
}
