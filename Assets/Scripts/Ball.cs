using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
//https://docs.unity3d.com/ScriptReference/RequireComponent.html
public class Ball : MonoBehaviour // de quien hereda? de mono
{       //https://docs.unity3d.com/ScriptReference/Transform.html
    //transform es un objeto o clase que nos da muchas 
    //como queremos atrapar al objeto paleta lo voy llamar raquets
    public Transform racquets; //paddle

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // levamos a decir que arranque pegado 
        // transform.position = paddle.position;

        //hacemos una resta para sacar la difencia de posicion
        float positionDifference = racquets.position.x - transform.position.x;
        transform.position = new Vector3(racquets.position.x - positionDifference, racquets.position.y, racquets.position.z); 
     
    }
}
  