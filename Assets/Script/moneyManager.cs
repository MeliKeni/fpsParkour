using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManager : MonoBehaviour
{

    public float money;
    public uiManager UIManager;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.UpdateMoneyTxt(money.ToString());
    }

    // Update is called once per frame
    public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza la plata");
            return;
        }
        money += moneyToAdd;
        UIManager.UpdateMoneyTxt(money.ToString());
    }
}
