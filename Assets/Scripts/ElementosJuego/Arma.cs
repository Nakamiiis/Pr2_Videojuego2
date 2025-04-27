using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Disparación
       if(Input.GetKeyDown(KeyCode.E)){
        Instantiate(bala, transform.position, Quaternion.identity);
        AudioManager.Instance.SuenaClip(AudioManager.Instance.sonidoFuego);
     
      }

    }
}
