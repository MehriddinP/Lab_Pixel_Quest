using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jeocontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public int speed = 5;
    public string nextLevel = "Scene_2";

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }
 
    // Update is called once per frame
    void Update()
    {
        /*float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        */
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput*speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.color = Color.yellow;


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.black;


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.blue;


        }


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene ().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
