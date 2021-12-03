using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBallFollow : MonoBehaviour
{
    public Transform ball;
    
    [SerializeField]
    private float speed = 0.05f; //coment 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ball.position.y) 
        {   //up
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }else if (transform.position.y > ball.position.y)
        {
            //down
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        }
    }
}
