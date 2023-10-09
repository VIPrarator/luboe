using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    public float speed = 5f; // скорость перемещения персонажа

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // получаем значение горизонтальной оси (A/D или ←/→)
        float moveVertical = Input.GetAxis("Vertical"); // получаем значение вертикальной оси (W/S или ↑/↓)

        Vector2 movement = new Vector2(moveHorizontal, moveVertical); // создаем вектор движения

        rb.velocity = movement * speed; // применяем скорость к вектору движения
    }
}