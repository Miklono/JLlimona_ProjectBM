using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongCreation : MonoBehaviour
{

    //Variables
    public Button creationButton;
    public Slider[] sliders;
    public Dropdown[] choises;
    public static int singValue;
    public static int guitarValue;
    public static int bassValue;
    public static int drumValue;
    public static int totalValue;
    public static int genere;
    public static int theme;
    public static string songName;
    public GameObject[] windows;
    public InputField songInput;
    public Text textTest;
    public int qualityPoints;
    public int originalityPoints;
    public int totallyQualityPoints;
    public int totallyOriginalityPoints;
    int waitTime;
    public Text qualityNumber;
    public Text originalityNumber;
    int timer;
    int cardTalentSing, cardTalentGuitar, cardTalentBass, cardTalentDrums;
    public GameObject gameManager;
    public int totalFinalPoints;
    public Button yes, no, mainMenu;
    public int songCreated = 0;
    public GameObject[] cards;
    public Text[] titles;
    int points = 0;
    int[] score = new int[3];
    int finalScore = 0;
    public Text[] scoreTexts;
    public Text finalScoreText;
    public Text[] punctiation;
    public GameObject[] songCards;
    public bool[] isSaved = new bool[28];
    public int[] finalPunctuationSaved = new int[28];


    // Start is called before the first frame update
    void Start()
    {
        yes.onClick.AddListener(ButtonYesClicked);
        no.onClick.AddListener(ButtonNoCliced);
        mainMenu.onClick.AddListener(ButtonMainMenu);
        creationButton.onClick.AddListener(createSong);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createSong()
    {
        cardTalentSing = gameManager.GetComponent<ChangeView>().cardTalent[0];
        cardTalentGuitar = gameManager.GetComponent<ChangeView>().cardTalent[1];
        cardTalentBass = gameManager.GetComponent<ChangeView>().cardTalent[2];
        cardTalentDrums = gameManager.GetComponent<ChangeView>().cardTalent[3];
        if (!(MaxPointsSlider.totalPoints > 20))
        {
            singValue = (int)sliders[0].value + cardTalentSing;
            guitarValue = (int)sliders[1].value + cardTalentGuitar;
            bassValue = (int)sliders[2].value + cardTalentBass;
            drumValue = (int)sliders[3].value + cardTalentDrums;
            genere = choises[0].value;
            theme = choises[1].value;
            songName = songInput.text;
            titles[songCreated].text = songName;
           

            if (genere == 0 && theme == 2)
            {
                totalValue = (singValue * 3) + guitarValue + bassValue + (drumValue * 2);
            }
            else if (genere == 1 && theme == 4)
            {
                totalValue = singValue + (guitarValue *2) + bassValue + (drumValue * 3);
            }
            else if (genere == 2 && theme == 1)
            {
                totalValue = (singValue * 3) + (guitarValue * 2) + bassValue + drumValue;
            }
            else if (genere == 2 && theme == 3)
            {
                totalValue = (singValue * 2) + (guitarValue * 3) + bassValue + drumValue;
            }
            else if (genere == 3 && theme == 0)
            {
                totalValue = (singValue * 3) + guitarValue + bassValue + (drumValue * 2);
            }
            else if (genere == 3 && theme == 5)
            {
                totalValue = (singValue * 2) + (guitarValue * 3) + bassValue + drumValue;
            }
            else
            {
                totalValue = singValue + guitarValue + bassValue + drumValue;
            }

            qualityPoints = (int)Random.Range(totalValue - 5, totalValue);
            originalityPoints = (int)Random.Range(totalValue - 5, totalValue);
            totalFinalPoints = qualityPoints + originalityPoints;
            qualityNumber.text = qualityPoints.ToString();
            originalityNumber.text = originalityPoints.ToString();


            windows[0].SetActive(false);
            windows[1].SetActive(true);
            
        }

        
    }

    void ButtonYesClicked()
    {
        windows[2].SetActive(true);
        windows[1].SetActive(false);
        points = totalFinalPoints;
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
        finalPunctuationSaved[songCreated] = finalScore;
        punctiation[songCreated].text = "score: " + finalScore.ToString();
        isSaved[songCreated] = true;
        songCreated++;
    }

    void ButtonNoCliced()
    {
        windows[0].SetActive(true);
        windows[1].SetActive(false);
    }

    void ButtonMainMenu()
    {
        windows[2].SetActive(false);
        windows[3].SetActive(true);
        cards[0].GetComponent<MoveCard>().songCreated();
        cards[1].GetComponent<MoveCard>().songCreated();
        cards[2].GetComponent<MoveCard>().songCreated();
        cards[3].GetComponent<MoveCard>().songCreated();
        cards[4].GetComponent<MoveCard>().songCreated();
        cards[5].GetComponent<MoveCard>().songCreated();
        cards[6].GetComponent<MoveCard>().songCreated();
        cards[7].GetComponent<MoveCard>().songCreated();
        cards[8].GetComponent<MoveCard>().songCreated();
        cards[9].GetComponent<MoveCard>().songCreated();
        cards[10].GetComponent<MoveCard>().songCreated();
        cards[11].GetComponent<MoveCard>().songCreated();
        cards[12].GetComponent<MoveCard>().songCreated();
        cards[13].GetComponent<MoveCard>().songCreated();
        cards[14].GetComponent<MoveCard>().songCreated();
        cards[15].GetComponent<MoveCard>().songCreated();
        gameManager.GetComponent<ChangeView>().isShowingCre = false;
        gameManager.GetComponent<ChangeView>().isShowingSC = false;
        gameManager.GetComponent<ChangeView>().isShowingDiscC = false;
    }
}

