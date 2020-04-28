using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeView : MonoBehaviour
{
    //Variables 
    public Button changeToContract, changeToManagement, changeToCreation, changeToMenuC, changeToMenuM, changeToMenuCre, changeToSongC;
    //changeToMenuC = Contract Windos. changeToMenuM = Band Management. ChangeToMenuCre = Creation Windows
    public GameObject mainWindow, contractWindow, managementWindow, creationWindow, songCWinwod;
    public GameObject dropdownMenu;
    public Transform singCard, singCard1, singCard2, singCard3, guitarCard, guitarCard1, guitarCard2, guitarCard3, bassCard, bassCard1, bassCard2, bassCard3, drumCard, drumCard1, drumCard2, drumCard3;
    public GameObject singWindow, guitarWindow, bassWindow, drumWindow;
    public Text singText, singText1, singText2, singText3, guitarText, guitarText1, guitarText2, guitarText3, bassText, bassText1, bassText2, bassText3, drumText, drumText1, drumText2, drumText3;
    private bool isShowingC, isShowingM, isShowingCre, isShowingSC;
    public GameObject gameManager;

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
            singText.text = "Choose";
            singCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard1.GetComponent<MoveCard>().isContracted)
        {
            singCard1.SetParent(singWindow.transform, false);
            singText1.text = "Choose";
            singCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard2.GetComponent<MoveCard>().isContracted)
        {
            singCard2.SetParent(singWindow.transform, false);
            singText2.text = "Choose";
            singCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (singCard3.GetComponent<MoveCard>().isContracted)
        {
            singCard3.SetParent(singWindow.transform, false);
            singText3.text = "Choose";
            singCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard.GetComponent<MoveCard>().isContracted)
        {
            guitarCard.SetParent(guitarWindow.transform, false);
            guitarText.text = "Choose";
            guitarCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard1.GetComponent<MoveCard>().isContracted)
        {
            guitarCard1.SetParent(guitarWindow.transform, false);
            guitarText1.text = "Choose";
            guitarCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard2.GetComponent<MoveCard>().isContracted)
        {
            guitarCard2.SetParent(guitarWindow.transform, false);
            guitarText2.text = "Choose";
            guitarCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (guitarCard3.GetComponent<MoveCard>().isContracted)
        {
            guitarCard3.SetParent(guitarWindow.transform, false);
            guitarText3.text = "Choose";
            guitarCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard.GetComponent<MoveCard>().isContracted)
        {
            bassCard.SetParent(bassWindow.transform, false);
            bassText.text = "Choose";
            bassCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard1.GetComponent<MoveCard>().isContracted)
        {
            bassCard1.SetParent(bassWindow.transform, false);
            bassText1.text = "Choose";
            bassCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard2.GetComponent<MoveCard>().isContracted)
        {
            bassCard2.SetParent(bassWindow.transform, false);
            bassText2.text = "Choose";
            bassCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (bassCard3.GetComponent<MoveCard>().isContracted)
        {
            bassCard3.SetParent(bassWindow.transform, false);
            bassText3.text = "Choose";
            bassCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard.GetComponent<MoveCard>().isContracted)
        {
            drumCard.SetParent(drumWindow.transform, false);
            drumText.text = "Choose";
            drumCard.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard1.GetComponent<MoveCard>().isContracted)
        {
            drumCard1.SetParent(drumWindow.transform, false);
            drumText1.text = "Choose";
            drumCard1.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard2.GetComponent<MoveCard>().isContracted)
        {
            drumCard2.SetParent(drumWindow.transform, false);
            drumText2.text = "Choose";
            drumCard2.GetComponent<MoveCard>().isOnCreation = true;
        }
        if (drumCard3.GetComponent<MoveCard>().isContracted)
        {
            drumCard3.SetParent(drumWindow.transform, false);
            drumText3.text = "Choose";
            drumCard3.GetComponent<MoveCard>().isOnCreation = true;
        }
    }
}
