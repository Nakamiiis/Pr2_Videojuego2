using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource miAudioSource;   
    public AudioClip bandaSonora;   
    public AudioClip sonidoMoneda;
    
    // Start is called before the first frame update
    void Start()
    {
        
        miAudioSource = GetComponent<AudioSource>();

        miAudioSource.clip = bandaSonora; 
        miAudioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
