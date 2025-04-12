using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;

    GameObject camera;

    public float velocidadParallax = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camera = GameObject.FindWithTag("MainCamera");

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void FixedUpdate()
    {
        transform.position = new Vector3(
            camera.transform.position.x/velocidadParallax, camera.transform.position.y/velocidadParallax, 0);


    }

}
