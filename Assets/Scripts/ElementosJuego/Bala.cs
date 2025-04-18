using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocidad = 5;

    GameObject player;

    public int potenciaArma = 1;


    // Start is called before the first frame update
    void Start()
    {
     player = GameObject.FindWithTag("Player");

     if(player.GetComponent<MovPersonaje>().direcciónBalaDcha == true){
          velocidad = velocidad*1;
        }

        if(player.GetComponent<MovPersonaje>().direcciónBalaDcha == false){
          velocidad = velocidad*-1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        float velocidadFinal = (velocidad * Time.deltaTime);
        transform.Translate(velocidadFinal, 0f, 0f);

         Destroy(this.gameObject, 7.0f);

    }

void OnTriggerEnter2D(Collider2D col){
    if(col.gameObject.name.StartsWith("enemigo_fantasma")){

        Destroy(this.gameObject);
         //Destroy(col.gameObject); para destruir fantasma, pero queremos que tenga vida

        col.gameObject.GetComponent<FantasmaScript>().vidaFantasma -= potenciaArma; //el -= es para restarle -1 más simple  

        }

    }


}
