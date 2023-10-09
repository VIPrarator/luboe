using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincamera : MonoBehaviour
{
    public Transform Player;
    public float smoothing = 5f;
    Vector2 offset;


    void Start()
    {
        offset = transform.position = Player.position;
    }

    void LateUpdate()
    {
        Vector2 PlayerCamPos = Player.position - Player.position;
        transform.position = Vector3.Lerp(transform.position, PlayerCamPos, smoothing * Time.deltaTime);
    }
}
