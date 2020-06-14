using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSquareGuyScripts : MonoBehaviour
{
    // Start is called before the first frame update

    //variables de salto
    public float fuerzaSalto = 3000f;
    public bool canJump = false;
    public float speed = 100;
    private SpriteRenderer mySpriteRenderer;


    void Start()
    {
         Debug.Log("Iniciando script");

    }


     // This function is called just one time by Unity the moment the component loads
   private void Awake()
   {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
   }

    // Update is called once per frame
    void Update()
    {
        //private bool hasStarted = false;
      
       
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = Mathf.MoveTowards(position.x, -300, speed * Time.deltaTime);
            this.transform.position = position;
               mySpriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x = Mathf.MoveTowards(position.x, +300, speed * Time.deltaTime);
            this.transform.position = position;
            mySpriteRenderer.flipX = true;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(canJump == true){
                     GetComponent <Rigidbody2D>().AddForce (new Vector2 (0,fuerzaSalto));
                    canJump = false;
            }
            
           
        }


        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
        */
    }


     //Detecta cuando hay collision con el suelo
    void OnCollisionEnter2D(Collision2D collision)
    {   
        Debug.Log("Verificando Colision");

        if (collision.gameObject.tag == "Floor")
        {   
            Debug.Log("canJump en true!");
            canJump = true;
        }
    }

  


}
