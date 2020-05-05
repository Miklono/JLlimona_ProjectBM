using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCard : MonoBehaviour
{
    //Variables
    public Button singButton, singButton1, singButton2, singButton3, guitarButton, guitarButton1, guitarButton2, guitarButton3, bassButton, bassButton1, bassButton2, bassButton3, drumButton, drumButton1, drumButton2, drumButton3;
    public GameObject singCard, singCard1, singCard2, singCard3, guitarCard, guitarCard1, guitarCard2, guitarCard3, bassCard, bassCard1, bassCard2, bassCard3, drumCard, drumCard1, drumCard2, drumCard3;
    public GameObject singWindow, guitarWindow, bassWindow, drumWindow, SCWindow;
    public int[] cardTalent = new int[4];
    int i;
    // Start is called before the first frame update
    void Start()
    {
        if (singCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard.SetActive(true);
            singButton.onClick.AddListener(delegate { CardChoosen(singCard); ChangStoG(); });
        }
        if (singCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard1.SetActive(true);
            singButton1.onClick.AddListener(delegate { CardChoosen(singCard1); ChangStoG(); });
        }
        if (singCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard2.SetActive(true);
            singButton2.onClick.AddListener(delegate { CardChoosen(singCard2); ChangStoG(); });
        }
        if (singCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            singCard3.SetActive(true);
            singButton3.onClick.AddListener(delegate { CardChoosen(singCard3); ChangStoG(); });
        }
        if (guitarCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton.onClick.AddListener(delegate { CardChoosen(guitarCard); ChangeGtoB(); });
        }
        if (guitarCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton1.onClick.AddListener(delegate { CardChoosen(guitarCard1); ChangeGtoB(); });
        }
        if (guitarCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton2.onClick.AddListener(delegate { CardChoosen(guitarCard2); ChangeGtoB(); });
        }
        if (guitarCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            guitarButton3.onClick.AddListener(delegate { CardChoosen(guitarCard3); ChangeGtoB(); });
        }
        if (bassCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton.onClick.AddListener(delegate { CardChoosen(bassCard); ChangeBtoD(); });
        }
        if (bassCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton1.onClick.AddListener(delegate { CardChoosen(bassCard1); ChangeBtoD(); });
        }
        if (bassCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton2.onClick.AddListener(delegate { CardChoosen(bassCard2); ChangeBtoD(); });
        }
        if (bassCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            bassButton3.onClick.AddListener(delegate { CardChoosen(bassCard3); ChangeBtoD(); });
        }
        if (drumCard.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton.onClick.AddListener(delegate { CardChoosen(drumCard); ChangeDtoSC(); });
        }
        if (drumCard1.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton1.onClick.AddListener(delegate { CardChoosen(drumCard1); ChangeDtoSC(); });
        }
        if (drumCard2.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton2.onClick.AddListener(delegate { CardChoosen(drumCard2); ChangeDtoSC(); });
        }
        if (drumCard3.GetComponent<MoveCard>().isOnCreation == true)
        {
            drumButton3.onClick.AddListener(delegate { CardChoosen(drumCard3); ChangeDtoSC(); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CardChoosen(GameObject card)
    {
        card.GetComponent<MoveCard>().isChoosed = true;
    }

    void ChangStoG()
    {
        singWindow.SetActive(false);
        singCard.SetActive(false);
        singCard1.SetActive(false);
        singCard2.SetActive(false);
        singCard3.SetActive(false);
        guitarWindow.SetActive(true);
        if (guitarCard.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard.SetActive(true);
        }
        if (guitarCard1.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard1.SetActive(true);
        }
        if (guitarCard2.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard2.SetActive(true);
        }
        if (guitarCard3.GetComponent<MoveCard>().isOnCreation)
        {
            guitarCard3.SetActive(true);
        }
    }

    void ChangeGtoB()
    {
        guitarWindow.SetActive(false);
        guitarCard.SetActive(false);
        guitarCard1.SetActive(false);
        guitarCard2.SetActive(false);
        guitarCard3.SetActive(false);
        bassWindow.SetActive(true);
        if (bassCard.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard.SetActive(true);
        }
        if (bassCard1.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard1.SetActive(true);
        }
        if (bassCard2.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard2.SetActive(true);
        }
        if (bassCard3.GetComponent<MoveCard>().isOnCreation)
        {
            bassCard3.SetActive(true);
        }
    }

    void ChangeBtoD()
    {
        bassWindow.SetActive(false);
        bassCard.SetActive(false);
        bassCard1.SetActive(false);
        bassCard2.SetActive(false);
        bassCard3.SetActive(false);
        drumWindow.SetActive(true);
        if (drumCard.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard.SetActive(true);
        }
        if (drumCard1.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard1.SetActive(true);
        }
        if (drumCard2.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard2.SetActive(true);
        }
        if (drumCard3.GetComponent<MoveCard>().isOnCreation)
        {
            drumCard3.SetActive(true);
        }

        
    }

    void ChangeDtoSC()
    {
        drumCard.SetActive(false);
        drumCard1.SetActive(false);
        drumCard2.SetActive(false);
        drumCard3.SetActive(false);
        drumWindow.SetActive(false);
        SCWindow.SetActive(true);
    }
}
