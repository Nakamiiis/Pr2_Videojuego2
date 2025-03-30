using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{

    private GameObject Rogue;

    private MovPersonaje movPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        Rogue = GameObject.Find("Rogue");
        movPersonaje = Rogue.GetComponent<MovPersonaje>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        Debug.Log(col.name);

        if(col.name == "Rogue"){
             movPersonaje.Respawnear();

        } 

    }


}
