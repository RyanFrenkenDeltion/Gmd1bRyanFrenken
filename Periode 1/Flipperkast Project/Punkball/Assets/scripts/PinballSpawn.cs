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
            GameObject.Find("Canvas End screen").GetComponent<CanvasGroup>().alpha = 1;
            
        }
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPinball();
        }
        
    }

    public void SpawnPinball()
    {
        if (currentball != null)
            return;

        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);
        currentball = pinball;
        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

   
}