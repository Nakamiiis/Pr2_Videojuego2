using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float Multiplicador = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      float MovTeclas = Input.GetAxis("Horizontal"); //Registro teclas a y d para moverse en eje x hasta -1f y 1f


float miDeltaTime = Time.deltaTime;

transform.Translate(
MovTeclas*(Time.deltaTime*Multiplicador),
0,
0
);



//Aproximación 1
      /*transform.position = new Vector3(
        transform.position.x+(MovTeclas/100),
        transform.y,
        transform.z
      );*/ 


    }
}
