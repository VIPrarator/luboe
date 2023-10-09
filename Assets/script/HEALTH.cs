using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HEALTH : MonoBehaviour
{
    public bombaboom script1;
    public Text textComponent;
    void Start()
    {
        script1 = GameObject.Find("ObjectWithbombaboom").GetComponent<bombaboom>();
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //int value = script1.live;
       // Debug.Log("Значение переменной myVariable: " + value);

    }
}
