using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BallBehaviour : MonoBehaviour
{

    public Rigidbody2D _rigidbody2d;
    public Transform player;
    //el bool siempre inicia con falso
    bool gameStarted = false;
  // float buttonMouse = Input.GetAxis("Jump");

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {

        //transform.position = player.position;
        //float positionDiferent =  player.position.x- transform.position.x;
        //transform.position = new Vector3(player.position.x - positionDiferent, player.position.y, player.position.z);


        //entoces lo que hacemos es 
        


    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            float positionDiferent = player.position.x - transform.position.x;
            transform.position = new Vector3(player.position.x - positionDiferent, player.position.y, player.position.z);
            
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody2d.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
        }
    }
}
/*
 tenemos que cambiar la escala de la gravedad global de todo el juego 


MATERIA DE FISICA EN EL COLLIDER 
mATERIAL (CARPETA) 
VAMOS A CREAR UN PHISICS MATERIAL 2D (Bouncy) 
FRICTION DE LA DEJAMOS A 0 
EL BOUNCINESS A 1 

una vez modificado tenemos que agregarselo a collider
 */