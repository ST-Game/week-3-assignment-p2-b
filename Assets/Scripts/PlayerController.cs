using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MoveSpeed, JumpSpeed;
    private Rigidbody2D theRG;

    // Start is called before the first frame update
    void Start()
    {
        theRG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
