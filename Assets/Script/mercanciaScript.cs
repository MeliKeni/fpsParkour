using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour
{
    public float cost;
    public moneyManager moneyManager;
    // Start is called before the first frame update
    private void Start()
    {
        moneyManager = FindObjectOfType<moneyManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //actualizar dinero por la compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);        
        }
    }
    
}