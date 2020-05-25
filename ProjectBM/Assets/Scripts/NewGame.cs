using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    //Un altre script que no serveix per res pero el mantenc per el record.
    //Estava pensat per ser un menu principal on podries triar si fer una nova partida, continuar...ç

    //Variables
    public Button newGame;
    public GameObject StartMenu, MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        newGame.onClick.AddListener(NewGameClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NewGameClick()
    {
        MainMenu.SetActive(true);
        Destroy(StartMenu);
    }
}
