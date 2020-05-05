using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeView : MonoBehaviour
{
    //Variables 
    public Button changeToContract, changeToManagement, changeToCreation, changeToMenuC, changeToMenuM, changeToMenuCre, changeToSongC, changeToStat, changeToSSong, changeToMenuStat, changeToStatSong;
    //changeToMenuC = Contract Windos. changeToMenuM = Band Management. ChangeToMenuCre = Creation Windows
    public GameObject mainWindow, contractWindow, managementWindow, creationWindow, songCWinwod, statWindow, songStat;
    public GameObject dropdownMenu;
    public Transform singCard, singCard1, singCard2, singCard3, guitarCard, guitarCard1, guitarCard2, guitarCard3, bassCard, bassCard1, bassCard2, bassCard3, drumCard, drumCard1, drumCard2, drumCard3;
    public GameObject singWindow, guitarWindow, bassWindow, drumWindow;
    private bool isShowingC, isShowingM, isShowingCre, isShowingSC, isShowingStat, isShowingSSong;
    public GameObject gameManager;
    public GameObject[] buttons;

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
        gameManager.GetComponent<ChooseCard>().enabled = true;
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
    }

    void ChangeStat()
    {
        isShowingStat = !isShowingStat;
        mainWindow.SetActive(!isShowingStat);
        statWindow.SetActive(isShowingStat);
    }

    void ChangeSSong()
    {
        isShowingSSong = !isShowingSSong;
        statWindow.SetActive(!isShowingSSong);
        songStat.SetActive(isShowingSSong);
    }
}
