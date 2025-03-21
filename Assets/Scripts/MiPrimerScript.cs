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

/*prueba comentario
con líneas*/

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Hola, mi nombre es "+miNombre);
        //Esto es una prueba de comentario hehe
    }
}
