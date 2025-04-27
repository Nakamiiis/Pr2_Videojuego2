using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
     GameObject audioManagerObj;
    AudioManager audioManagerScript;

    // Start is called before the first frame update
    void Start()
    {
      audioManagerObj = GameObject.Find("AudioManagerObj"); 
        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SuenaBoton()
    {
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoBoton);
    }

     public void GameOverExit()
    {
        Application.Quit();  
    }
}
