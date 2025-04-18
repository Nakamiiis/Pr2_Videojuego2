using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{

    GameObject panelSettings;
    GameObject audioManagerObj;
    AudioManager audioManagerScript;

    // Start is called before the first frame update
    void Start()
    {
    
        panelSettings = GameObject.Find("PanelSettings");
            panelSettings.SetActive(false);

        audioManagerObj = GameObject.Find("AudioManagerObj"); 
        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();    

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InicioPlay() 
    {
        //Debug.Log("ola");
        SceneManager.LoadScene("Scene1");
    }

     public void InicioSettings() 
    {
        panelSettings.SetActive(true);

    }

    public void InicioSettingsExit() 
    {
        panelSettings.SetActive(false);

    }

    public void SuenaBoton()
    {
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoBoton);
    }

    public void InicioExit() 
    {
      Application.Quit();  

    }

}
