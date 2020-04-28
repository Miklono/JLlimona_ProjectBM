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
    public Button yes, no; 

    // Start is called before the first frame update
    void Start()
    {
        yes.onClick.AddListener(ButtonYesClicked);
        no.onClick.AddListener(ButtonNoCliced);
    }

    // Update is called once per frame
    void Update()
    {
        creationButton.onClick.AddListener(createSong);
        cardTalentSing = gameManager.GetComponent<ChooseCard>().cardTalent[0];
        cardTalentGuitar = gameManager.GetComponent<ChooseCard>().cardTalent[1];
        cardTalentBass = gameManager.GetComponent<ChooseCard>().cardTalent[2];
        cardTalentDrums = gameManager.GetComponent<ChooseCard>().cardTalent[3];
    }

    void createSong()
    {
        if (!(MaxPointsSlider.totalPoints > 20))
        {
            singValue = (int)sliders[0].value + cardTalentSing;
            guitarValue = (int)sliders[1].value + cardTalentGuitar;
            bassValue = (int)sliders[2].value + cardTalentBass;
            drumValue = (int)sliders[3].value + cardTalentDrums;
            genere = choises[0].value;
            theme = choises[1].value;
            songName = songInput.text;

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
        gameManager.GetComponent<Puntuation>().enabled = true;
    }

    void ButtonNoCliced()
    {
        windows[0].SetActive(true);
        windows[1].SetActive(false);
    }
}

