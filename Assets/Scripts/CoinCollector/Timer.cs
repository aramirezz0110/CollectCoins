using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    //variables para el tiempo, si o si float
    public float maxTime = 60.0f;
    private float countDown = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //'deltaTime' es el tiempo en segundos desde la renderizacion del ultimo frame
        countDown -= Time.deltaTime;
        Debug.Log(countDown);
        if (countDown <= 0)
        {
            Debug.Log("HAS PERDIDO");
            Coin.coinsCount = 0;
            //para obtener el nombre actual de la escena
            string currentScene = SceneManager.GetActiveScene().name;
            //para recargar la escena actual
            SceneManager.LoadScene(currentScene);
        }
    }
}
