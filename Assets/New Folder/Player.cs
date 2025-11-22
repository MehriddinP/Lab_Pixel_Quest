using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f; // скорость движения

    void Update()
    {
        // Получаем ввод
        float x = Input.GetAxisRaw("Horizontal"); // влево/вправо
        float y = Input.GetAxisRaw("Vertical");   // вверх/вниз

        // Направление движения
        Vector2 move = new Vector2(x, y);

        // Двигаем героя
        transform.position += (Vector3)move * speed * Time.deltaTime;
    }

}
