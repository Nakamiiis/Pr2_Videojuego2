using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

public int miEdad = 21;
public float miAltura = 1.69f;
public string miNombre = "Lu";
public bool llueve = false;

public GameObject miCubo;

public int numero1 = 10;

public int numero2 = 80;

public Vector3 posInicial = new Vector3(0, 0, 0);

public Color miColor;

public float velocidad = 1.0f;

/*prueba comentario
con líneas*/

    // Start is called before the first frame update
    void Start()
    {
      //this.GetComponent<Transform>().position = posInicial; es igual como está abajo
     /* transform.position = posInicial;

      this.GetComponent<SpriteRenderer>().flipX = true;
    */
    }

    // Update is called once per frame*/
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){ //Ir a la izquierda
            transform.Translate(velocidad*-1,0,0);
        }

        if(Input.GetKey(KeyCode.D)){ //Ir a la derecha
            transform.Translate(velocidad,0,0);
        }


   // float posicionActual = this.GetComponent<Transform>().position.x;        //.x para variar solo eso y no y-z
      //  this.GetComponent<Transform>().position = new Vector3(posicionActual+0.001f, 0, 0);

      // int suma = Sumar(numero1,numero2);
   // Debug.Log("La suma es "+ suma);

     // this.GetComponent<SpriteRenderer>().color = miColor;

    // transform.Translate(velocidad, 0, 0);
     //transform.rotation = Quaternion.Euler (0,0,5); por ejemplo
    //Debug.Log(transform.eulerAngles); para ver los ángulos en grados dentro de unity
    //transform.Rotate(0,0,velocidad);
    //transform.localscale(valores);   para que escale



 /*int Sumar(int numero1, int numero2){
  int resultado = numero1+numero2;
  return resultado;



 }

    
}

   
    
    

    void onGUI(){
        if(Event.current.isMouse && Event.current.button == 0){
        Debug.Log(Event.current.type.ToString()); 
        }
*/
}
}