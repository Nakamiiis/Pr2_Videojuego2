using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{


GameObject Respawn;


    // Start is called before the first frame update
    void Start()
    {
      Respawn = GameObject.Find("respawn");

    }

    // Update is called once per frame
    void Update()
    {
       // spawn = GameObject.Find("Respawn");


    }

    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player")
        {
        Respawn.transform.position = transform.position;
        GameManager.vidas = GameManager.vidas + 1;
         Debug.Log("Vidas: "+GameManager.vidas);

        Destroy(this.gameObject); 
        }
        
    }

  
}
