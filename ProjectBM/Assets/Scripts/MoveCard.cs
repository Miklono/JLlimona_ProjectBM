using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCard : MonoBehaviour
{

    //Variable
    public Transform card;
    public Transform windows1;
    public Transform windows2;
    public GameObject contract;
    public Text contractText;
    public bool isContracted = false;
    public bool isOnCreation = false;
    public bool isChoosed = false;
    public GameObject gameManager;
    int cost;
    int money;
    //public static bool isContractedExternal;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = contract.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        cost = card.gameObject.GetComponent<CardVariables>().cost;
        
    }

    // Update is called once per frame
    void Update()
    {
        money = gameManager.GetComponent<Time>().money;
    }

    //Mou la carta a de la pestanya de contractació a la administració
    void TaskOnClick()
    {
        if (!isOnCreation && money >= cost) //Nomes ho fa si el jugador te els diners requerits
        {
            isContracted = true;
            card.SetParent(windows1, false);
            contract.SetActive(false);
            //Redueix els diners al jugador
            gameManager.GetComponent<Time>().moneyGained = -cost; 
            gameManager.GetComponent<Time>().setMoneyText();
        }
    }

    //Torna la carta a l'estat anterior a la creació de la canço
    public void songCreated()
    {
        if (isChoosed)
        {
            card.SetParent(windows1, false);
            contract.SetActive(false);
            card.gameObject.SetActive(true);
            isChoosed = false;
            isOnCreation = false;
        }
    }
    

}
