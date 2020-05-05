using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuation : MonoBehaviour
{

    //Variables
    int points;
    public GameObject gameManager;
    int[] score = new int[3];
    public int finalScore;
    public Text[] scoreTexts;
    public Text finalScoreText;
    public int songCreated;
    public Text[] punctiation;
    public GameObject[] songCards;



    // Start is called before the first frame update
    void Start()
    {       
        points = gameManager.GetComponent<SongCreation>().totalFinalPoints;
        if (points >= 210)
        {
            score[0] = 10;
            score[1] = 10;
            score[2] = 10;
        }
        else if (points >= 175 && points < 210)
        {
            score[0] = (int)Random.Range(7, 9);
            score[1] = (int)Random.Range(7, 9);
            score[2] = (int)Random.Range(7, 9);
        }
        else if (points >= 100 && points < 175)
        {
            score[0] = (int)Random.Range(5, 7);
            score[1] = (int)Random.Range(5, 7);
            score[2] = (int)Random.Range(5, 7);
        }
        else
        {
            score[0] = (int)(Random.Range(0, 4));
            score[1] = (int)(Random.Range(0, 4));
            score[2] = (int)(Random.Range(0, 4));
        }

        scoreTexts[0].text = score[0].ToString();
        scoreTexts[1].text = score[1].ToString();
        scoreTexts[2].text = score[2].ToString();
        finalScore = (int)((score[0] + score[1] + score[2]) / 3);
        finalScoreText.text = finalScore.ToString();
        punctiation[songCreated].text = "score: " + finalScore.ToString();
        gameManager.GetComponent<Puntuation>().enabled = false;
        songCreated++;
        for (int i = 0; i < songCreated; i++)
        {
            songCards[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
