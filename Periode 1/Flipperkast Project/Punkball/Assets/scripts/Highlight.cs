using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Highlight : MonoBehaviour {
    public Material touched;
    public Material unTouched;
    public float switchDuration;
    public AudioClip[] bounceClip1;
    public AudioSource bounceSound;
    

    void OnCollisionEnter()
    {
        
        StartCoroutine(MaterialSwitch());
        PlayBounceSound();
    }

    IEnumerator MaterialSwitch() 
    {
        GetComponent<Renderer>().material = touched;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<Renderer>().material = unTouched;

    }

    void PlayBounceSound()
    {
        Debug.Log(1);
        int randClip = Random.Range(0, bounceClip1.Length);
        bounceSound.clip = bounceClip1[randClip];
        bounceSound.Play();
    }
}
