using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class jeocontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 100;

    string varible1 = "hello";
    int varible2 = 11375;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log(varible1 + varible2);
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        /*float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        */
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput*speed, rb.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.W))

        {
            Debug.Log(varible2++);
            transform.position += new Vector3(0, 1, 0);
    
        
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        */
        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        


        rb.velocity = Vector2.left;
        */
    } 

   
}
