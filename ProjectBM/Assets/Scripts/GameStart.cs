using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    //Variables
    public GameObject startMenu, mainWindow, managementWindow, contractWindow, dropdownMenu, creationMenu;

    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        mainWindow.SetActive(false);
        managementWindow.SetActive(false);
        contractWindow.SetActive(false);
        dropdownMenu.SetActive(false);
        creationMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
