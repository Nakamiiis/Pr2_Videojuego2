using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeonSabio : MonoBehaviour
{
    public Canvas CanvasLeon;  

    // Start is called before the first frame update
    void Start()
    {
         CanvasLeon.GetComponent<Canvas>().enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        


    }

void OnTriggerEnter2D(Collider2D col){
    if(col.gameObject.name.StartsWith("Rogue")){
         CanvasLeon.GetComponent<Canvas>().enabled = true;
         //Debug.Log("ola soy el león sabio");
     }
}
void OnTriggerExit2D(Collider2D col){
    if(col.gameObject.name.StartsWith("Rogue")){
        CanvasLeon.GetComponent<Canvas>().enabled = false;
         //Debug.Log("ola soy el león sabio");
     }
}

}
