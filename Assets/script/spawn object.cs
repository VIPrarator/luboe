using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
    [SerializeField ]
    public GameObject obj; // объект, который нужно создать
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;


    void Update()
    {
        if(Time.time >nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(5f, 900f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
