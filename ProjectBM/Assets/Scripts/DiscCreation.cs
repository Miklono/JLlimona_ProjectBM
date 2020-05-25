using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscCreation : MonoBehaviour
{

    //Variables
    public Button[] songCards = new Button[28];
    public int[] cardScore = new int[28];
    public int songsChoosed = 0;
    public GameObject gameManager;
    public Button discCreation;
    public bool[] isChoosed = new bool[28];
    public Text songNumber, songText, costNumber, costText;
    public Button createButton;
    public GameObject punctuationWindow, discCWindow;
    public Text[] scoreText;
    public Text finalScoreText;
    int finalScore;
    int[] scores = new int[3];
    public GameObject headerText, backCreation, backButton;
    int cost;
    int money;

    // Start is called before the first frame update
    void Start()
    {
        discCreation.onClick.AddListener(CreateDisc);
        createButton.onClick.AddListener(produceDisc);
    }

    // Update is called once per frame
    void Update()
    {
        money = gameManager.GetComponent<Time>().money; //Guarda els diners actuals
    }

    //Funcio per fer la creacio del disc
    void CreateDisc()
    {
        
        for (int i = 0; i < 28; i++)
        {
            songCards[i].gameObject.GetComponent<SongChosseTest>().enabled = true; //Activa l'script que permet canvia el color quan es seleciona una canço
        }
        songCards[0].onClick.RemoveAllListeners();
        songCards[0].onClick.AddListener(delegate { songChoosed(songCards[0].gameObject, 0); });
        songCards[1].onClick.RemoveAllListeners();
        songCards[1].onClick.AddListener(delegate { songChoosed(songCards[1].gameObject, 1); });
        songCards[2].onClick.RemoveAllListeners();
        songCards[2].onClick.AddListener(delegate { songChoosed(songCards[2].gameObject, 2); });
        songCards[3].onClick.RemoveAllListeners();
        songCards[3].onClick.AddListener(delegate { songChoosed(songCards[3].gameObject, 3); });
        songCards[4].onClick.RemoveAllListeners();
        songCards[4].onClick.AddListener(delegate { songChoosed(songCards[4].gameObject, 4); });
        songCards[5].onClick.RemoveAllListeners();
        songCards[5].onClick.AddListener(delegate { songChoosed(songCards[5].gameObject, 5); });
        songCards[6].onClick.RemoveAllListeners();
        songCards[6].onClick.AddListener(delegate { songChoosed(songCards[6].gameObject, 6); });
        songCards[7].onClick.RemoveAllListeners();
        songCards[7].onClick.AddListener(delegate { songChoosed(songCards[7].gameObject, 7); });
        songCards[8].onClick.RemoveAllListeners();
        songCards[8].onClick.AddListener(delegate { songChoosed(songCards[8].gameObject, 8); });
        songCards[9].onClick.RemoveAllListeners();
        songCards[9].onClick.AddListener(delegate { songChoosed(songCards[9].gameObject, 9); });
        songCards[10].onClick.RemoveAllListeners();
        songCards[10].onClick.AddListener(delegate { songChoosed(songCards[10].gameObject, 10); });
        songCards[11].onClick.RemoveAllListeners();
        songCards[11].onClick.AddListener(delegate { songChoosed(songCards[11].gameObject, 11); });
        songCards[12].onClick.RemoveAllListeners();
        songCards[12].onClick.AddListener(delegate { songChoosed(songCards[12].gameObject, 12); });
        songCards[13].onClick.RemoveAllListeners();
        songCards[13].onClick.AddListener(delegate { songChoosed(songCards[13].gameObject, 13); });
        songCards[14].onClick.RemoveAllListeners();
        songCards[14].onClick.AddListener(delegate { songChoosed(songCards[14].gameObject, 14); });
        songCards[15].onClick.RemoveAllListeners();
        songCards[15].onClick.AddListener(delegate { songChoosed(songCards[15].gameObject, 15); });
        songCards[16].onClick.RemoveAllListeners();
        songCards[16].onClick.AddListener(delegate { songChoosed(songCards[16].gameObject, 16); });
        songCards[17].onClick.RemoveAllListeners();
        songCards[17].onClick.AddListener(delegate { songChoosed(songCards[17].gameObject, 17); });
        songCards[18].onClick.RemoveAllListeners();
        songCards[18].onClick.AddListener(delegate { songChoosed(songCards[18].gameObject, 18); });
        songCards[19].onClick.RemoveAllListeners();
        songCards[19].onClick.AddListener(delegate { songChoosed(songCards[19].gameObject, 19); });
        songCards[20].onClick.RemoveAllListeners();
        songCards[20].onClick.AddListener(delegate { songChoosed(songCards[20].gameObject, 20); });
        songCards[21].onClick.RemoveAllListeners();
        songCards[21].onClick.AddListener(delegate { songChoosed(songCards[21].gameObject, 21); });
        songCards[22].onClick.RemoveAllListeners();
        songCards[22].onClick.AddListener(delegate { songChoosed(songCards[22].gameObject, 22); });
        songCards[23].onClick.RemoveAllListeners();
        songCards[23].onClick.AddListener(delegate { songChoosed(songCards[23].gameObject, 23); });
        songCards[24].onClick.RemoveAllListeners();
        songCards[24].onClick.AddListener(delegate { songChoosed(songCards[24].gameObject, 24); });
        songCards[25].onClick.RemoveAllListeners();
        songCards[25].onClick.AddListener(delegate { songChoosed(songCards[25].gameObject, 25); });
        songCards[26].onClick.RemoveAllListeners();
        songCards[26].onClick.AddListener(delegate { songChoosed(songCards[26].gameObject, 26); });
        songCards[27].onClick.RemoveAllListeners();
        songCards[27].onClick.AddListener(delegate { songChoosed(songCards[27].gameObject, 27); });
    }

    void songChoosed(GameObject card, int i)
    {
        if (!isChoosed[i])
        {
            cardScore[songsChoosed] = gameManager.GetComponent<SongCreation>().finalPunctuationSaved[i]; //Agafa la puntuacio de quan es va crea la canço
            isChoosed[i] = true; //Diu que ha estat triada
            songsChoosed++; //Augmenta el contador de cançons triades
            cost = songsChoosed * 100; //Defineix el cost de la creacio del disc
            changeCostText();
            changeSongText();
        }
        else if (isChoosed[i])
        {
            songsChoosed--; //Reduiex en un el nombre de cançons escullides
            cardScore[songsChoosed] = 0; //Cambia el valor de la puntuacio a 0
            isChoosed[i] = false; //Diu que la canço es no ha estat escullida
            changeSongText();
        }
    }

    //Mostra el nombre de cançons que ha escullit
    public void changeSongText()
    {
        songNumber.text = songsChoosed.ToString();
    }

    void produceDisc()
    {
        if(songsChoosed >= 7 && money >= cost) //Nomes deixa activa la funcio si ha escullit 7 o mes cançons i si te els diners requerits
        {
            for (int i = 0; i < songsChoosed; i++)
            {
                finalScore = finalScore + cardScore[i]; //Suma totes les puntuacions de les cançons escollides
            }
            finalScore = (int)finalScore / songsChoosed; //Fa la mitja de les puntuacions sumades
            //Les tres puntuacions es un numero aleatori de la mitja de les puntuacions i un mes, perque sembli que hi ha varitat d'opinio sense perjudicar molt
            scores[0] = (int)Random.Range(finalScore, finalScore + 1);
            scores[1] = (int)Random.Range(finalScore, finalScore + 1);
            scores[2] = (int)Random.Range(finalScore, finalScore + 1);
            finalScore = (scores[0] + scores[1] + scores[2]) / 3; // La puntuacio final es La mitja de les tres puntuacions generades aleatoriament
            //Mostra el rsultat al jugador
            scoreText[0].text = scores[0].ToString();
            scoreText[1].text = scores[1].ToString();
            scoreText[2].text = scores[2].ToString();
            finalScoreText.text = finalScore.ToString();
            //Cambia a la finestra de puntuació
            discCWindow.SetActive(false);
            punctuationWindow.SetActive(true);
            //Torna tot al seu estat inicial
            for (int i = 0; i<28; i++)
            {
                songCards[i].gameObject.SetActive(false);
                songCards[i].gameObject.GetComponent<SongChosseTest>().changeColorToDefault();
                gameManager.GetComponent<SongCreation>().isSaved[i] = false;
                gameManager.GetComponent<SongCreation>().songCreated = 0;
            }
            headerText.SetActive(false);
            createButton.gameObject.SetActive(false);
            backCreation.SetActive(false);
            songText.gameObject.SetActive(false);
            songNumber.gameObject.SetActive(false);
            costText.gameObject.SetActive(false);
            costNumber.gameObject.SetActive(false);
            backButton.SetActive(true);
           
            gameManager.GetComponent<Time>().moneyGained = -cost; //Cambia la variable de diners guanyats al cost en negatiu
            gameManager.GetComponent<Time>().setMoneyText(); //Cambia el text de diners
            //Depenent de la puntuació el jugador gunaya mes o menys diners.
            if (finalScore < 5)
            {
                gameManager.GetComponent<Time>().moneyGained = 1000;
            }
            else if (finalScore >= 5 || finalScore < 7)
            {
                gameManager.GetComponent<Time>().moneyGained = 5000;
            }
            else if (finalScore >= 7 || finalScore < 8)
            {
                gameManager.GetComponent<Time>().moneyGained = 8000;
            }
            else if (finalScore >= 8 || finalScore <= 9)
            {
                gameManager.GetComponent<Time>().moneyGained = 10000;
            }
            else if (finalScore == 10)
            {
                gameManager.GetComponent<Time>().moneyGained = 20000;
            }

            gameManager.GetComponent<Time>().setMoneyText();
        }
    }

    //Mostra el cost a l'usuari
    void changeCostText()
    {
        costNumber.text = cost.ToString() + "$";
    }

}
