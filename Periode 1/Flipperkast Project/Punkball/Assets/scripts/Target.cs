using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {   
    [HideInInspector]
    public bool activated;
    public GameObject[] targets;

	void OnCollisionEnter(Collision x)
    {
        if(x.transform.tag == "Ball")
        {
            activated = true;
        }
        bool combo = true;
        foreach (GameObject target in transform.parent.GetComponent<Target>().targets)
        {
            if (target.GetComponent<Target>().activated == false)
            {
                combo = false;
            }
        }
        if(combo == true)
        {
            //hier kan je een combo reward geven
        }
    }
}
