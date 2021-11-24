using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private void FixedUpdate()
    {
        float vertical = Input.GetAxis("Mouse Y");
        Vector3 mousePositionScreen = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //position x y z  
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(mousePositionScreen.y,-2f,2f),transform.position.z);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
