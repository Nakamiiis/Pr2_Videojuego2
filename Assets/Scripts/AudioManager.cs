using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource miAudioSource;   
    public AudioClip bandaSonora;   
    public AudioClip sonidoMoneda;

    public AudioClip sonidoFantasma;

    public AudioClip sonidoBotón;

    public static AudioManager Instance; //para llamarlo desed cualquier lugar, solo habrá 1

    void Awake() 
    {
       
       if(Instance != null && Instance != this) 
        {
            Destroy(this.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            }
     
       DontDestroyOnLoad(this.gameObject);
    }
    
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

    public void SuenaMoneda()
    {
        miAudioSource.PlayOneShot(sonidoMoneda);
    }

    public void SuenaClip(AudioClip miClip)
    {
        miAudioSource.PlayOneShot(miClip);
    }
}
