using UnityEngine;
using System.Collections;

public class BarricadeSensor : MonoBehaviour {

    public GameObject[] obstruction; //lijst van GameObjects
    private bool visible = true;
    public Material triggerd;
    public Material unTriggerd;
    public int switchDuration;

    void OnTriggerEnter(Collider x) // dit maakt de rode stip in het midden een censor, waardoor de barricades verdwijnen en terugkomen.
    {
        StartCoroutine(MaterialSwitch());

        print(1);
        if (visible) //zet alles onzichtbaar (Credits naar Jan (De man die alles kan) voor het helpen.)
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

    IEnumerator MaterialSwitch() //hiermee word de rode stip verlicht doormiddel van het veranderen van de Material voor een bepaald aantal secondens lang.
    {
        GetComponent<Renderer>().material = triggerd;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<Renderer>().material = unTriggerd;
    }
  
      

}
