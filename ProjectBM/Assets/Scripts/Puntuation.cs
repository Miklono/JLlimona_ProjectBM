using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuation : MonoBehaviour
{

    //Variables
    int points;
    public GameObject gameManager;
    int score;
    //public Text[] socreTexts;
    public Text finalScoreText;


    // Start is called before the first frame update
    void Start()
    {
        points = gameManager.GetComponent<SongCreation>().totalFinalPoints;
        if (points >= 210)
        {
            score = 10;
        }
        else if (points >= 175 && points < 210)
        {
            score = (int)Random.Range(7, 9);
        }
        else if (points >= 100 && points < 175)
        {
            score = (int)Random.Range(5, 7);
        }
        else
        {
            score = (int)(Random.Range(0, 4));
        }

        finalScoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
