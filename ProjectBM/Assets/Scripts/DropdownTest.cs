using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTest : MonoBehaviour
{

    //Variables
    public Dropdown changeCaract;
    public GameObject cardSing;
    public GameObject cardSing1;
    public GameObject cardSing2;
    public GameObject cardSing3;
    public GameObject cardGuitar;
    public GameObject cardGuitar1;
    public GameObject cardGuitar2;
    public GameObject cardGuitar3;
    public GameObject cardBass;
    public GameObject cardBass1;
    public GameObject cardBass2;
    public GameObject cardBass3;
    public GameObject cardDrums;
    public GameObject cardDrums1;
    public GameObject cardDrums2;
    public GameObject cardDrums3;



    // Start is called before the first frame update
    void Start()
    {
        changeCaract = GetComponent<Dropdown>();
        changeCaract.onValueChanged.AddListener(delegate
        {
           changeCards();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeCards()
    {
        if (changeCaract.value == 0)
        {
            cardSing.SetActive(true);
            cardSing1.SetActive(true);
            cardSing2.SetActive(true);
            cardSing3.SetActive(true);
            cardGuitar.SetActive(false);
            cardGuitar1.SetActive(false);
            cardGuitar2.SetActive(false);
            cardGuitar3.SetActive(false);
            cardBass.SetActive(false);
            cardBass1.SetActive(false);
            cardBass2.SetActive(false);
            cardBass3.SetActive(false);
            cardDrums.SetActive(false);
            cardDrums1.SetActive(false);
            cardDrums2.SetActive(false);
            cardDrums3.SetActive(false);
        }
        else if (changeCaract.value == 1)
        {
            cardSing.SetActive(false);
            cardSing1.SetActive(false);
            cardSing2.SetActive(false);
            cardSing3.SetActive(false);
            cardGuitar.SetActive(true);
            cardGuitar1.SetActive(true);
            cardGuitar2.SetActive(true);
            cardGuitar3.SetActive(true);
            cardBass.SetActive(false);
            cardBass1.SetActive(false);
            cardBass2.SetActive(false);
            cardBass3.SetActive(false);
            cardDrums.SetActive(false);
            cardDrums1.SetActive(false);
            cardDrums2.SetActive(false);
            cardDrums3.SetActive(false);
        }
        else if (changeCaract.value == 2)
        {
            cardSing.SetActive(false);
            cardSing1.SetActive(false);
            cardSing2.SetActive(false);
            cardSing3.SetActive(false);
            cardGuitar.SetActive(false);
            cardGuitar1.SetActive(false);
            cardGuitar2.SetActive(false);
            cardGuitar3.SetActive(false);
            cardBass.SetActive(true);
            cardBass1.SetActive(true);
            cardBass2.SetActive(true);
            cardBass3.SetActive(true);
            cardDrums.SetActive(false);
            cardDrums1.SetActive(false);
            cardDrums2.SetActive(false);
            cardDrums3.SetActive(false);
        }
        else if (changeCaract.value == 3)
        {
            cardSing.SetActive(false);
            cardSing1.SetActive(false);
            cardSing2.SetActive(false);
            cardSing3.SetActive(false);
            cardGuitar.SetActive(false);
            cardGuitar1.SetActive(false);
            cardGuitar2.SetActive(false);
            cardGuitar3.SetActive(false);
            cardBass.SetActive(false);
            cardBass1.SetActive(false);
            cardBass2.SetActive(false);
            cardBass3.SetActive(false);
            cardDrums.SetActive(true);
            cardDrums1.SetActive(true);
            cardDrums2.SetActive(true);
            cardDrums3.SetActive(true);
        }
    }
}
