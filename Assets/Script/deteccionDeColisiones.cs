using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}