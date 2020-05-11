using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeView : MonoBehaviour
{
    //Variables 
    public Button changeToContract, changeToManagement, changeToCreation, changeToMenuC, changeToMenuM, changeToMenuCre, changeToSongC, changeToStat, changeToSSong, changeToMenuStat, changeToStatSong, changeToDiscC;
    //changeToMenuC = Contract Windos. changeToMenuM = Band Management. ChangeToMenuCre = Creation Windows
    public GameObject mainWindow, contractWindow, managementWindow, creationWindow, songCWinwod, statWindow, songStat, SCWindow;
    public GameObject dropdownMenu;
    public Transform singCard, singCard1, singCard2, singCard3, guitarCard, guitarCard1, guitarCard2, guitarCard3, bassCard, bassCard1, bassCard2, bassCard3, drumCard, drumCard1, drumCard2, drumCard3;
    public GameObject singWindow, guitarWindow, bassWindow, drumWindow;
    public bool isShowingC, isShowingM, isShowingCre, isShowingSC, isShowingStat, isShowingSSong, isShowingDiscC;
    public GameObject gameManager;
    public GameObject[] buttons;
    public int[] cardTalent = new int[4];
    public int i;
    public Button singButton, singButton1, singButton2, singButton3, guitarButton, guitarButton1, guitarButton2, guitarButton3, bassButton, bassButton1, bassButton2, bassButton3, drumButton, drumButton1, drumButton2, drumButton3;
    public GameObject[] songCard;
    public Button backButton, backCreation;
    public bool[] isOnDiscCreation = new bool[28];
    public GameObject discQText;
    public Text songNumber, songText;
    public Button createButton;

    // Start is called before the first frame update
    void Start()
    {
        dropdownMenu.GetComponent<Dropdown>();
        changeToContract.onClick.AddListener(ChangeContract);
        changeToMenuC.onClick.AddListener(ChangeContract);
        changeToManagement.onClick.AddListener(ChangeManagement);
        changeToMenuM.onClick.AddListener(ChangeManagement);
        changeToCreation.onClick.AddListener(ChangeCreation);
        changeToMenuCre.onClick.AddListener(ChangeCreation);
        changeToSongC.onClick.AddListener(ChangeSCreation);
        changeToStat.onClick.AddListener(ChangeStat);
        changeToMenuStat.onClick.AddListener(ChangeStat);
        changeToSSong.onClick.AddListener(ChangeSSong);
        changeToStatSong.onClick.AddListener(ChangeSSong);
        changeToDiscC.onClick.AddListener(ChangeDiscC);
        backCreation.onClick.AddListener(ChangeDiscC);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeContract()
    {
        isShowingC = !isShowingC;
        contractWindow.SetActive(isShowingC);
        mainWindow.SetActive(!isShowingC);
        dropdownMenu.SetActive(isShowingC);
        
    }

    void ChangeManagement()
    {
        isShowingM = !isShowingM;
        managementWindow.SetActive(isShowingM);
        mainWindow.SetActive(!isShowingM);
        dropdownMenu.SetActive(isShowingM);
    }

    void ChangeCreation()
    {
        isShowingCre = !isShowingCre;
        creationWindow.SetActive(isShowingCre);
        mainWindow.SetActive(!isShowingCre);
    }
    void ChangeSCreation()
    {
        i = 0;

        isShowingSC = !isShowingSC;
        songCWinwod.SetActive(isShowingSC);
        singWindow.SetActive(isShowingSC);
        guitarWindow.SetActive(!isShowingSC);
        bassWindow.SetActive(!isShowingSC);
        drumWindow.SetActive(!isShowingSC);
        creationWindow.SetActive(!isShowingSC);
        if (singCard.GetComponent<MoveCard>().isContracted)
        {
            singCard.SetParent(singWindow.transform, false);
            buttons[0].SetActive(true);
            singCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard1.GetComponent<MoveCard>().isContracted)
        {
            singCard1.SetParent(singWindow.transform, false);
            buttons[1].SetActive(true);
            singCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard2.GetComponent<MoveCard>().isContracted)
        {
            singCard2.SetParent(singWindow.transform, false);
            buttons[2].SetActive(true);
            singCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard3.GetComponent<MoveCard>().isContracted)
        {
            singCard3.SetParent(singWindow.transform, false);
            buttons[3].SetActive(true);
            singCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard.GetComponent<MoveCard>().isContracted)
        {
            guitarCard.SetParent(guitarWindow.transform, false);
            buttons[4].SetActive(true);
            guitarCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard1.GetComponent<MoveCard>().isContracted)
        {
            guitarCard1.SetParent(guitarWindow.transform, false);
            buttons[5].SetActive(true);
            guitarCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard2.GetComponent<MoveCard>().isContracted)
        {
            guitarCard2.SetParent(guitarWindow.transform, false);
            buttons[6].SetActive(true);
            guitarCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard3.GetComponent<MoveCard>().isContracted)
        {
            guitarCard3.SetParent(guitarWindow.transform, false);
            buttons[7].SetActive(true);
            guitarCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard.GetComponent<MoveCard>().isContracted)
        {
            bassCard.SetParent(bassWindow.transform, false);
            buttons[8].SetActive(true);
            bassCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard1.GetComponent<MoveCard>().isContracted)
        {
            bassCard1.SetParent(bassWindow.transform, false);
            buttons[9].SetActive(true);
            bassCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard2.GetComponent<MoveCard>().isContracted)
        {
            bassCard2.SetParent(bassWindow.transform, false);
            buttons[10].SetActive(true);
            bassCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard3.GetComponent<MoveCard>().isContracted)
        {
            bassCard3.SetParent(bassWindow.transform, false);
            buttons[11].SetActive(true);
            bassCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard.GetComponent<MoveCard>().isContracted)
        {
            drumCard.SetParent(drumWindow.transform, false);
            buttons[12].SetActive(true);
            drumCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard1.GetComponent<MoveCard>().isContracted)
        {
            drumCard1.SetParent(drumWindow.transform, false);
            buttons[13].SetActive(true);
            drumCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard2.GetComponent<MoveCard>().isContracted)
        {
            drumCard2.SetParent(drumWindow.transform, false);
            buttons[14].SetActive(true);
            drumCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard3.GetComponent<MoveCard>().isContracted)
        {
            drumCard3.SetParent(drumWindow.transform, false);
            buttons[15].SetActive(true);
            drumCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard.gameObject.SetActive(true);
            singButton.GetComponent<Button>().onClick.RemoveAllListeners();
            singButton.onClick.AddListener(delegate { CardChoosen(singCard.gameObject); ChangStoG(); });
        }
        if (singCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard1.gameObject.SetActive(true);
            singButton1.GetComponent<Button>().onClick.RemoveAllListeners();
            singButton1.onClick.AddListener(delegate { CardChoosen(singCard1.gameObject); ChangStoG(); });
            
        }
        if (singCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard2.gameObject.SetActive(true);
            singButton2.GetComponent<Button>().onClick.RemoveAllListeners();
            singButton2.onClick.AddListener(delegate { CardChoosen(singCard2.gameObject); ChangStoG(); });
        }
        if (singCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard3.gameObject.SetActive(true);
            singButton3.GetComponent<Button>().onClick.RemoveAllListeners();
            singButton3.onClick.AddListener(delegate { CardChoosen(singCard3.gameObject); ChangStoG(); });
        }
        if (guitarCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton.GetComponent<Button>().onClick.RemoveAllListeners();
            guitarButton.onClick.AddListener(delegate { CardChoosen(guitarCard.gameObject); ChangeGtoB(); });
        }
        if (guitarCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton1.GetComponent<Button>().onClick.RemoveAllListeners();
            guitarButton1.onClick.AddListener(delegate { CardChoosen(guitarCard1.gameObject); ChangeGtoB(); });
        }
        if (guitarCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton2.GetComponent<Button>().onClick.RemoveAllListeners();
            guitarButton2.onClick.AddListener(delegate { CardChoosen(guitarCard2.gameObject); ChangeGtoB(); });
        }
        if (guitarCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton3.GetComponent<Button>().onClick.RemoveAllListeners();
            guitarButton3.onClick.AddListener(delegate { CardChoosen(guitarCard3.gameObject); ChangeGtoB(); });
        }
        if (bassCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton.GetComponent<Button>().onClick.RemoveAllListeners();
            bassButton.onClick.AddListener(delegate { CardChoosen(bassCard.gameObject); ChangeBtoD(); });
        }
        if (bassCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton1.GetComponent<Button>().onClick.RemoveAllListeners();
            bassButton1.onClick.AddListener(delegate { CardChoosen(bassCard1.gameObject); ChangeBtoD(); });
        }
        if (bassCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton2.GetComponent<Button>().onClick.RemoveAllListeners();
            bassButton2.onClick.AddListener(delegate { CardChoosen(bassCard2.gameObject); ChangeBtoD(); });
        }
        if (bassCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton3.GetComponent<Button>().onClick.RemoveAllListeners();
            bassButton3.onClick.AddListener(delegate { CardChoosen(bassCard3.gameObject); ChangeBtoD(); });
        }
        if (drumCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton.GetComponent<Button>().onClick.RemoveAllListeners();
            drumButton.onClick.AddListener(delegate { CardChoosen(drumCard.gameObject); ChangeDtoSC(); });
        }
        if (drumCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton1.GetComponent<Button>().onClick.RemoveAllListeners();
            drumButton1.onClick.AddListener(delegate { CardChoosen(drumCard1.gameObject); ChangeDtoSC(); });
        }
        if (drumCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton2.GetComponent<Button>().onClick.RemoveAllListeners();
            drumButton2.onClick.AddListener(delegate { CardChoosen(drumCard2.gameObject); ChangeDtoSC(); });
        }
        if (drumCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton3.GetComponent<Button>().onClick.RemoveAllListeners();
            drumButton3.onClick.AddListener(delegate { CardChoosen(drumCard3.gameObject); ChangeDtoSC(); });
        }
    }

    void ChangeStat()
    {
        isShowingStat = !isShowingStat;
        mainWindow.SetActive(!isShowingStat);
        statWindow.SetActive(isShowingStat);
        for(int i = 0; i < 28; i++)
        {
            if (gameManager.GetComponent<SongCreation>().isSaved[i])
            {
                songCard[i].SetActive(true);
            }
        }
    }

    void ChangeSSong()
    {
        isShowingSSong = !isShowingSSong;
        statWindow.SetActive(!isShowingSSong);
        songStat.SetActive(isShowingSSong);
        
    }

    void CardChoosen(GameObject card)
    {
        card.GetComponent<MoveCard>().isChoosed = true;
        cardTalent[i] = card.GetComponent<CardVariables>().talent;
        i = i + 1;
    }

    void ChangStoG()
    {
        singWindow.SetActive(false);
        singCard.gameObject.SetActive(false);
        singCard1.gameObject.SetActive(false);
        singCard2.gameObject.SetActive(false);
        singCard3.gameObject.SetActive(false);
        guitarWindow.SetActive(true);
        if (guitarCard.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard.gameObject.SetActive(true);
        }
        if (guitarCard1.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard1.gameObject.SetActive(true);
        }
        if (guitarCard2.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard2.gameObject.SetActive(true);
        }
        if (guitarCard3.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard3.gameObject.SetActive(true);
        }
    }

    void ChangeGtoB()
    {
        guitarWindow.SetActive(false);
        guitarCard.gameObject.SetActive(false);
        guitarCard1.gameObject.SetActive(false);
        guitarCard2.gameObject.SetActive(false);
        guitarCard3.gameObject.SetActive(false);
        bassWindow.SetActive(true);
        if (bassCard.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard.gameObject.SetActive(true);
        }
        if (bassCard1.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard1.gameObject.SetActive(true);
        }
        if (bassCard2.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard2.gameObject.SetActive(true);
        }
        if (bassCard3.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard3.gameObject.SetActive(true);
        }
    }

    void ChangeBtoD()
    {
        bassWindow.SetActive(false);
        bassCard.gameObject.SetActive(false);
        bassCard1.gameObject.SetActive(false);
        bassCard2.gameObject.SetActive(false);
        bassCard3.gameObject.SetActive(false);
        drumWindow.SetActive(true);
        if (drumCard.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard.gameObject.SetActive(true);
        }
        if (drumCard1.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard1.gameObject.SetActive(true);
        }
        if (drumCard2.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard2.gameObject.SetActive(true);
        }
        if (drumCard3.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard3.gameObject.SetActive(true);
        }


    }

    void ChangeDtoSC()
    {
        drumCard.gameObject.SetActive(false);
        drumCard1.gameObject.SetActive(false);
        drumCard2.gameObject.SetActive(false);
        drumCard3.gameObject.SetActive(false);
        drumWindow.SetActive(false);
        SCWindow.SetActive(true);
        gameManager.GetComponent<SongCreation>().enabled = true;
    }

    void ChangeDiscC()
    {
        isShowingDiscC = !isShowingDiscC;
        for (int i = 0; i < 28; i++)
        {
            if (gameManager.GetComponent<SongCreation>().isSaved[i])
            {
                songCard[i].SetActive(isShowingDiscC);
                isOnDiscCreation[i] = true;

            }
            else if (!(gameManager.GetComponent<SongCreation>().isSaved[i]))
            {
                songCard[i].SetActive(!isShowingDiscC);
                isOnDiscCreation[i] = false;
            }
            songCard[i].gameObject.GetComponent<SongChosseTest>().changeColorToDefault();
        }
        gameManager.GetComponent<DiscCreation>().songsChoosed = 0;
        gameManager.GetComponent<DiscCreation>().changeSongText();
        creationWindow.SetActive(!isShowingDiscC);
        songStat.SetActive(isShowingDiscC);
        backButton.gameObject.SetActive(!isShowingDiscC);
        backCreation.gameObject.SetActive(isShowingDiscC);
        discQText.SetActive(isShowingDiscC);
        createButton.gameObject.SetActive(isShowingDiscC);
        songText.gameObject.SetActive(isShowingDiscC);
        songNumber.gameObject.SetActive(isShowingDiscC);
    }
}
