using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    public int vidaFantasma = 5;
    public float velocidad = 2;
    public float limitDerecha = 5;
    public float limitIzquierda = 5;

    private Vector3 posLimitDcha;
    private Vector3 posLimitIzq;

    private bool direcFantasmaDerecha = true;

    private Vector3 posInicial;

    private string estadoFantasma = "Patrol";

    private GameObject player;

    private float distancia;

    public float distanciaPatrol = 3;

    public float distanciaAtaque = 5;

    public float velocidadAtaque = 4;

    private MovPersonaje respawn;



    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        posLimitDcha = posInicial + new Vector3(limitDerecha, posInicial.y, 0);
        posLimitIzq = posInicial - new Vector3(limitIzquierda, posInicial.y, 0);

        player = GameObject.FindWithTag("Player");

        respawn = player.GetComponent<MovPersonaje>();


    }

    // Update is called once per frame
    void Update()
    {

        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= distanciaAtaque)
        {
            estadoFantasma = "Ataque";
        }

        if (distancia >= distanciaPatrol)
        {
            estadoFantasma = "Patrol";
        }


        //ATAQUE
        if (estadoFantasma == "Ataque")
        {
                transform.position = Vector3.MoveTowards(
                transform.position, player.transform.position, velocidadAtaque * Time.deltaTime
                );
            }
           
         if(player.transform.position.x <= transform.position.x){
                    this.GetComponent<SpriteRenderer>().flipX = false;
                }else{
                    this.GetComponent<SpriteRenderer>().flipX = true;
        }



        //PATROL
        if (estadoFantasma == "Patrol")
        {
            //transform.position = Vector3.MoveTowards(transform.position, posInicial, velocidad * Time.deltaTime);

            if (vidaFantasma <= 0)
            {
                Destroy(this.gameObject);
                GameManager.muertes += 1;
            }
            //Fantasma hacia derecha
            if (direcFantasmaDerecha == true)
            {
                transform.Translate(velocidad * Time.deltaTime, 0, 0);
                this.GetComponent<SpriteRenderer>().flipX = true;

            }

            //Fantasma hacia izquierda
            if (direcFantasmaDerecha == false)
            {
                transform.Translate((velocidad * Time.deltaTime) * -1, 0, 0);
                this.GetComponent<SpriteRenderer>().flipX = false;

            }

            //Comprobar si salimos del límite derecho
            if (transform.position.x >= posLimitDcha.x)
            {
                direcFantasmaDerecha = false;

            }

            //Comprobar si salimos del límite izquierdo
            if (transform.position.x <= posLimitIzq.x)
            {
                direcFantasmaDerecha = true;

            }
        }


                //Debug.Log(distancia + "***"+estadoFantasma);

            
    }
            void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                //GameManager.vidas -=1;
                respawn.Respawnear();
            }

        }
}