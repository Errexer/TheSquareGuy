using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public GameObject particle;
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Disparando");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
                Instantiate(particle, transform.position, transform.rotation);
        }
    }
}

public class PistolScripts : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //obtener la posicion del objecto
            var gObj = GameObject.Find("TheSquareGuy");

            //creo una nueva posicion basandome en la del TheSquareGuy y le sumo 1 valor en eje X
            var newPosition = new Vector3(gObj.transform.position.x + 0.8f, gObj.transform.position.y, gObj.transform.position.z);
         
         //mueve la pistola a donde esta el SquareGuy
            transform.position = Vector3.MoveTowards(transform.position, newPosition, 1);
    }
}
