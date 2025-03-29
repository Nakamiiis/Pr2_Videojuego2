using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float Multiplicador = 5f;

    public float MultiplicadorSalto = 5f;

    private bool PuedoSaltar = true;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
    //Movimiento personaje
      float MovTeclas = Input.GetAxis("Horizontal"); //Registro teclas a y d para moverse en eje x hasta -1f y 1f
      //float MovTeclasY = Input.GetAxis("Vertical"); para moverse en eje y

      float miDeltaTime = Time.deltaTime; //Regular frames con movimiento

      rb.velocity = new Vector2(MovTeclas*Multiplicador, rb.velocity.y);
     

      //Flip
      if(MovTeclas < 0){
        this.GetComponent<SpriteRenderer>().flipX = true;
      }else if(MovTeclas > 0){
        this.GetComponent<SpriteRenderer>().flipX = false;
      }

//Otra manera: transform.localScale = new Vector3(-1,1,1);  (X = -1 <- / x = 1 -> )
         //A esta manera puedes poner localScale.x*-1 o 1 para que puedas escalarlo sin afectar el flip (y-z ->localScale.y o z)



    //SAlto personaje
      RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        //Debug.DrawRay(transform.position, Vector2.down, Color.black);

      if(hit){
        PuedoSaltar = true;
        //Debug.Log(hit.collider.name);
      }
      else{
        PuedoSaltar = false;
      }

      //Para saltar y poner límite a cantidad saltos
      if(Input.GetKeyDown(KeyCode.Space) && PuedoSaltar){
        rb.AddForce(
          new Vector2(0,MultiplicadorSalto),
          ForceMode2D.Impulse
        );
       // PuedoSaltar = false;
      }


    }




  
  /*void onCollisionEnter2D(){  //Cuenta todo tipo de colisión
    PuedoSaltar = true;
  }*/

//Aproximación 1
      /*transform.position = new Vector3(
        transform.position.x+(MovTeclas/100),
        transform.y,
        transform.z
      );*/ 

//Aproximación 2
      /*transform.Translate(   //Para moverse más allá del 1 eje x
        MovTeclas*(Time.deltaTime*Multiplicador),
        0,
        0
       );*/



}
