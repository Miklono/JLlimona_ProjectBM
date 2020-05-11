using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongChosseTest : MonoBehaviour
{

    public Button btnTest;
    public bool colorChanged;
    public GameObject card;
    public Color defaultColor;
    

    // Start is called before the first frame update
    void Start()
    {
        btnTest.onClick.AddListener(changeColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
 
        if (!colorChanged)
        {
            card.GetComponent<Image>().color = Color.green;
            colorChanged = true;
        }
        else
        {
            card.GetComponent<Image>().color = defaultColor;
            colorChanged = false;
        }
    }

    public void changeColorToDefault()
    {
        card.GetComponent<Image>().color = defaultColor;
    }
}
