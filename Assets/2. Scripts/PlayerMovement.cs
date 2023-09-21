using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float x = 0;
    private float z = 0;

    public float Speed = 5;

    public GameObject body;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (x, 0 ,z);
        transform.Translate(movement * Time.deltaTime * Speed);

        if(movement != Vector3.zero)
        {
            body.transform.forward = movement;
        }
    }
}
