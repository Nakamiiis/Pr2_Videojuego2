using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

public static int vidas = 3;

public static int marcador = 0;

public static bool iAmDead = false;

public static int muertes = 0;

private GameObject vidasTexto;
private GameObject monedasTexto;
private GameObject puntosTexto;




    // Start is called before the first frame update
    void Start()
    {

        vidasTexto = GameObject.Find("VidasTexto");
        monedasTexto = GameObject.Find("MonedasTexto");
        puntosTexto = GameObject.Find("PuntosTexto");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Monedas: "+GameManager.marcador);

        vidasTexto.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
        monedasTexto.GetComponent<TextMeshProUGUI>().text = marcador.ToString();
        puntosTexto.GetComponent<TextMeshProUGUI>().text = muertes.ToString();


    }
}
