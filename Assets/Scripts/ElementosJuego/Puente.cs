using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente : MonoBehaviour
{
    //private bool soyTransparente = false;

     private Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        animatorController = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
      /*if(soyTransparente == true){
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
        }else{
        soyTransparente = false;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }*/
    }

   void OnCollisionEnter2D(Collision2D collision)
        { //Debug.Log(collision.gameObject.tag == "Player");
            if (collision.gameObject.tag == "Player")
                { 
                    animatorController.SetBool("avisoCaida", true);
                    Destroy(this.gameObject, 3.0f);
                }
            else{  
                animatorController.SetBool("avisoCaida", false);
                }
               
        }









//PRIMER INTENTO---Los else no se activaban así que no se recuperaba el puente
   
     /*void OnCollisionEnter2D(Collision2D collision)
        { //Debug.Log(collision.gameObject.tag == "Player");

                if (collision.gameObject.tag == "Player")
                {  Debug.Log("Caigoo");
                    this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                }

                else if (collision.gameObject.tag != "Player")
                {   Debug.Log("Volvi");
                    this.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                    this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                }
            
               if (collision.gameObject.tag == "Player")
                { 
                    soyTransparente = true;
                }else{
                    soyTransparente = false;  
                }
         }*/
}
