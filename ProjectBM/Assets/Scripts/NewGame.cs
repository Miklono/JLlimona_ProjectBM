using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{

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
