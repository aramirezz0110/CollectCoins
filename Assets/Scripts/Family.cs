using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person mother;
    public Person father;
    public Person son;
    // Start is called before the first frame update
    void Start()
    {
        //instanciacion de objetos
        father = new Person();
        father.firstName = "Desmond";
        father.lastName = "Miles";
        father.age = 22;
        father.isMale = true;
        father.isMarried = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
