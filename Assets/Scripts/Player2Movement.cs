
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    
    [SerializeField] 
     private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal2"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float y = Input.GetAxis("Vertical2");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise

        Vector3 movementVector;
        
        // transform.position = Vector3.MoveTowards(transform.position, target, step);

        if(y != 0){
            movementVector = new Vector3(x, y*6, 0) * speed * Time.deltaTime;
        }else{
            movementVector = new Vector3(x, y, 0) * speed * Time.deltaTime;
        }
        transform.position += movementVector;
    }
}
