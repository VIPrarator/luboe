using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class poedanieobject : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("clown"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
