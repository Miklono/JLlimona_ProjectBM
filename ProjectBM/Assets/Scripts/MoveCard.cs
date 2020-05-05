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
    //public static bool isContractedExternal;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = contract.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        if (!isOnCreation)
        {
            isContracted = true;
            card.SetParent(windows1, false);
            contract.SetActive(false);
        }
    }

    public void songCreated()
    {
        if (isChoosed)
        {
            card.SetParent(windows1, false);
            contract.SetActive(false);
            isChoosed = false;
            isOnCreation = false;
        }
    }
    

}
