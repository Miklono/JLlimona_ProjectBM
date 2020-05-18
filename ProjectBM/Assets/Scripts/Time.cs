using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{

    //Variables
    public Text timeText, moneyText;
    int counter;
    int day = 1;
    int week = 1;
    int month = 1;
    int year = 1;
    public int money = 5000;
    public int moneyGained = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimePas", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetTimeText()
    {
        timeText.text = "Y: " + year + " M: " + month + " W: " + week + " D: " + day;
    }

    void TimePas()
    {
        day++;
        if (day >= 8)
        {
            day = 1;
            week++;
        }
        if (week >= 5)
        {
            week = 1;
            month++;
            moneyGained = -800;
        }
        if (month >= 13)
        {
            month = 1;
            year++;
        }

        SetTimeText();
        setMoneyText();
    }

    public void setMoneyText()
    {
        money = money + moneyGained;
        moneyText.text = "Money: " + money.ToString() + "$";
        moneyGained = 0;
    }
}
