using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f; // скорость движения
    private Animator animator;

    private void Start()
    {
         animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Получаем ввод
        float x = Input.GetAxisRaw("Horizontal"); // влево/вправо
        float y = Input.GetAxisRaw("Vertical");   // вверх/вниз

        // Направление движения
        Vector2 move = new Vector2(x, y);

        // Двигаем героя
        transform.position += (Vector3)move * speed * Time.deltaTime;

        if(move.magnitude > 0)
        {
            animator.SetBool("isRunning ", true);
        }
        else
        {
                    animator.SetBool("isRunning", false);
        }
    }

}
