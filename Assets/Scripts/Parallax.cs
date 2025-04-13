using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;

    GameObject camera;

    public float velocidadParallax = 1;

    public Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camera = GameObject.FindWithTag("MainCamera");
        posInicial = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
      /* transform.position = posInicial + camera.transform.position;
       transform.position = new Vector3(
        posInicial.x + (camera.transform.position.x * velocidadParallax),
        posInicial.y,
        0);*/

    }

    void FixedUpdate()
    {
       
       
       
       transform.position = new Vector3(
            camera.transform.position.x/velocidadParallax, camera.transform.position.y/velocidadParallax, 0);


    }

}
