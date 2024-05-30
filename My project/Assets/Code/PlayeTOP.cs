using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeTOP : MonoBehaviour
{
    public float speed = 5f;
    public float acceleration = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Движение
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        Vector2 movement = new Vector2(moveX, moveY);

        // Ускорение
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement *= acceleration;
        }

        rb.AddForce(movement * speed);

        // Стрельба
        if (Input.GetMouseButtonDown(0))
        {
            // Получаем позицию мыши в мировом пространстве
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Вычисляем направление движения снаряда
            Vector2 direction = (mousePosition - transform.position).normalized;

            // Создаем снаряд
            GameObject bullet = Instantiate(Resources.Load("Bullet"), transform.position, Quaternion.identity) as GameObject;

            // Устанавливаем направление движения снаряда
            bullet.GetComponent<Rigidbody2D>().AddForce(direction * 1000);
        }
    }
}
