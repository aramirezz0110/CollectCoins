using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //variable global y estatica (una para todas las monedas)
    public static int coinsCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        Coin.coinsCount++; //incrementar la cantidad de monedas
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //en caso de que el Gameobject sea 'trigger'
    private void OnTriggerEnter(Collider other)
    {
        //other es cualquier otro objeto que se colisiona
        //Debug.Log("Primera colision del objeto");
        //destruir la moneda
        if (other.CompareTag("Player")==true) //verificacion si el que colisiona con la moneda es el jugador
        {
            
            Coin.coinsCount--; //disminuir la cantidad de monedas
            Debug.Log("Cantidad de monedas: "+Coin.coinsCount);
            if (Coin.coinsCount == 0) //para indicar que ya no quedan mas monedas por recoger
            {
                Debug.Log("El juego ha terminado");
                GameObject timerManager = GameObject.Find("TimerManager"); //busqueda del Gameobject dentro de la escena
                Destroy(timerManager); //destruimos el timer manager para detener el tiempo
                
            }
            Destroy(gameObject); //'gameobject' en minuscula hace referencia al objeto que tiene el script como componente
        }
    } 
    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("Colision continua");
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Ya no existe colision");
    }
    
}
