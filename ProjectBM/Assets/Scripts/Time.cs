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
        InvokeRepeating("TimePas", 1f, 1f); //Cada segon repeteix la funcio TimePas
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Cambia el text del temps
    void SetTimeText()
    {
        timeText.text = "Y: " + year + " M: " + month + " W: " + week + " D: " + day;
    }

    //Funcio que controla el pas del temps
    void TimePas()
    {
        day++; //Cada segon es un dia
        if (day >= 8) //Cada 8 dies es una setmana
        {
            day = 1;
            week++;
        }
        if (week >= 5) //Cada 5 setmanes es un mes
        {
            week = 1;
            month++;
            moneyGained = -800; //Cada mes el jugador perd 800$
        }
        if (month >= 13) //Cada 13 mesos es un any
        {
            month = 1;
            year++;
        }
        //Els dies, mesos i anys son un més perque el jugador veigi que esta a la setmana 4 i al pasar a la 5, cambia directament a mes: 2 - setmana: 1

        SetTimeText(); 
        setMoneyText();
    }

    //Cambia la quantitat de dienrs del jugador
    public void setMoneyText()
    {
        money = money + moneyGained; //Gracies aixo, nomes m'he de preocupar de cambiar la variable moneyGained, positiu si es benefici i negatiu si son perdues
        moneyText.text = "Money: " + money.ToString() + "$"; //Cambia el text dels diners
        moneyGained = 0; //Un cop actualitzat els beneficis pasan a 0 per que no estiguis guanyat o perdent cada segon
    }
}
