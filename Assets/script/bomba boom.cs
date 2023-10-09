using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaboom : MonoBehaviour
{
    public float scaleFactor = 1.5f;
    public Sprite boom;
    public int a = 2;
    private void Start()
    {
        
    }
    void Gravity()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("clown"))
        {
            Gravity();
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.gravityScale = 2f;
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = boom;
            transform.localScale = new Vector3(60f, 60f, 100f);

        }
        if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
