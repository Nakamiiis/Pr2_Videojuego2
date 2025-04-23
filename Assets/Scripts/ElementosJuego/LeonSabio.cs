using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeonSabio : MonoBehaviour
{
    GameObject PanelLeon;

    // Start is called before the first frame update
    void Start()
    {
      PanelLeon = GameObject.Find("PanelLeon");
        //PanelLeon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
void OnTriggerEnter2D(Collider2D col){
    if(col.gameObject.name.StartsWith("Rogue")){
        PanelLeon.SetActive(true);
        //Debug.Log("ola soy el león sabio");
     }
}
}
