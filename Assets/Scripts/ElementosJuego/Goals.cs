using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
public int valor = 1;

GameObject audioManagerObj;

    // Start is called before the first frame update
    void Start()
    {

     audioManagerObj = GameObject.Find("AudioManagerObj");

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
      if(col.tag == "Player"){

        GameManager.marcador = GameManager.marcador+valor;

        this.GetComponent<Animator>().SetBool("destruirMoneda", true);

        //audioManagerObj.GetComponent<AudioManager>().SuenaMoneda();
        AudioManager.Instance.SuenaClip(AudioManager.Instance.sonidoMoneda);

        Destroy(this.gameObject, 1.0f);
     }  


    }

}
