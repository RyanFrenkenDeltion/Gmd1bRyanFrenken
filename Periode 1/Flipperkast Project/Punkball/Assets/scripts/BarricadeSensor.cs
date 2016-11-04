using UnityEngine;
using System.Collections;

public class BarricadeSensor : MonoBehaviour {

    public GameObject[] obstruction; //lijst van GameObjects
    private bool visible = true;

    void OnTriggerEnter(Collider x)
    {
        print(1);
        if (visible) //zet alles onzichtbaar
        {
            for (int i = 0; i < obstruction.Length; i++) //i is eerst 0, dan 1 enz enz tot de lengte van de lijst
            {
                obstruction[i].SetActive(false); //de i (zoveelste) uit de lijst pakken
            }
        }
        else //zet alles zichtbaar
        {
            for (int i = 0; i < obstruction.Length; i++)
            {
                obstruction[i].SetActive(true);
            }
        }

        visible = !visible; //als zichtbaar dan onzichtbaar, als onzichtbaar dan zichtbaar
    }
}
