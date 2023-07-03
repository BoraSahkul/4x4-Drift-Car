using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn : MonoBehaviour
/*{
    AudioSource horn;

    public void Start()
    {
        horn = GetComponent<AudioSource>();
        
    }

    public void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            horn.Play();
            Debug.Log("horny");
        }
    }
  

}*/
{
    public AudioClip soundClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            PlaySound();
        }
    }

    private void PlaySound()
    {
        audioSource.clip = soundClip;
        audioSource.Play();
    }
}