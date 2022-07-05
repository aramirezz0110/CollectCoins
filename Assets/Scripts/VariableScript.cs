using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    //SECCION DE VARIABLES:  en lo posible que el nombre describa el comportamiento que debería tener
    public int myNumber = 30;
    public int total;

    public int number1;
    public int number2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.Escape);   
    }
    //DEFINICION DE METODOS
    //metodo para la suma de dos numeros
    void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
