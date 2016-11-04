using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class PinballSpawn : MonoBehaviour
{
    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    private GameObject currentball;
    
    
    
    
    
  
    void Update()
    {
        if(GameObject.Find("Deathwall").GetComponent<Deathwall>().lifetaker == 0)
        {
            GameObject.Find("Canvas End screen").GetComponent<CanvasGroup>().alpha = 1; // dit maakt de afbeelding met de eind scherm zichtbaar waneer je levens(lifetaker int) op 0 staan.

        }
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPinball(); //Dit spawned een ball als je op de linkse muisknop drukt.
        }
        
    }

    public void SpawnPinball()
    {
        if (currentball != null)
            return;
        // dit zorgt ervoor dat er maar 1 bal in het spel kan zijn tegelijkertijd.
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);
        currentball = pinball;
        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

   
}