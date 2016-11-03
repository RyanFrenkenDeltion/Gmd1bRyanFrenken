using UnityEngine;
using System.Collections;

public class Deathwall : MonoBehaviour {

    public int lifetaker = 3;
	
    void OnTriggerEnter(Collider Other) {
        {
            Destroy(Other.gameObject);
            lifetaker += -1;
        }

    }
}
