using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBadSquareGuyScripts : MonoBehaviour
{
     public float speed = 100;
     public bool left = true;

     //declara variable de tipo SPriteRender para acceder al componente
     private SpriteRenderer mySpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake()
    {
            // Instancia el componente SpriteRender para poder utilizarlo
            mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;

        if(left == true){
            position.x = Mathf.MoveTowards(position.x, -300, speed * Time.deltaTime);
             mySpriteRenderer.flipX = false;
        }else{
             position.x = Mathf.MoveTowards(position.x, 300, speed * Time.deltaTime);
              mySpriteRenderer.flipX = true;
        }
       
        this.transform.position = position;
    }


      //Detecta cuando hay collision con el suelo
    void OnCollisionEnter2D(Collision2D collision)
    {   
        Debug.Log("Verificando Colision");

        if (collision.gameObject.tag == "Wall")
        {   
            if(left == true){
                left = false;
            }else{
                left = true;
            }
        }
    }
}
