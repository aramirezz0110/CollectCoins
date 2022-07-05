using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    //ARRAY DEFINITION
    public string[] students = new string[] { "Christian", "Kate", "Mia", "Anastacia" };
    public string[] familyNames = new string[4];
    public int[] numberOfDoors = new int[] { 1, 2, 3, 4, 5};
    private bool [] hasPassedTheExam = new bool[]{ true, false, true};
    //LIST DEFINITION, son dependientes de la libreria: using System.Collections.Generic;
    public List<string> studentsNames = new List<string>();
    //ARRAYLIST DEFINITION
    public ArrayList inventory = new ArrayList();
    //HASHTABLE DEFINITION
    public Hashtable personalDetails = new Hashtable();
    void Start()
    {
        //forma de añadir elementos a una lista, al final de la lista
        studentsNames.Add("Desmond Miles"); //primer elemento
        studentsNames.Add("Ezio Auditore"); //segundo elemento

        //forma de añadir un elemento en una posicion en especifico: arrayName.Insert(index, "Content");
        studentsNames.Insert(2, "Connor Kenway");
        //comprobar la existencia de un elemento en una lista
        if(studentsNames.Contains("Jack Tompson"))
        {
            //eliminar un elemento de la lista
            studentsNames.Remove("Jack Tompson");
        }
        //convertir una lista en un array: arrayName.ToArray();
        string[] studentsNameArray = studentsNames.ToArray();
        //eliminacion de todos los elementos de la lista
        studentsNames.Clear();

        //forma de añadir elementos al ArrayList
        inventory.Add(12);
        inventory.Add(12.4545);
        inventory.Add("Loquita");
        inventory.Add(true);

        //forma de añadir elementos al Diccionario
        personalDetails.Add("firstName","Desmond"); // hashTableName.Add(key, value);
        personalDetails.Add("lastName", "Miles"); 


        //SHOW ELEMENTS
        int pos = 0;
        //FOR ARRAY
        Debug.Log(students[0]); //para acceder al elemento de la posicion n
        if (pos>= 0 && pos< students.Length)
        {
            Debug.Log(students.Length); //para saber la cantidad de elementos del array
        }        

        //FOR LIST
        Debug.Log(studentsNames[0]); //para acceder al elemento de la posicion n
        if (pos>=0 && pos< studentsNames.Count)
        {
            Debug.Log(studentsNames.Count); //para saber la cantidad de elementos de la lista
        }

        //FOR ARRAYLIST
        Debug.Log(inventory[0].GetType()); //para saber el tipo de dato del elemento de la posion N dentro del array

        //FOR HASHTABLES
        if (personalDetails.Contains("Desmond"))
        {
            Debug.Log(personalDetails["Desmond"]); //realiza la busqueda por claves
        }     

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
