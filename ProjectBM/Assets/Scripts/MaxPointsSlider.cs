using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxPointsSlider : MonoBehaviour
{

    //Variables
    public Slider[] sliders;
    int maxPoints = 20;
    public static int totalPoints;
    public Text pointsText;
    public Color deafult = new Color (50f, 50f, 50f, 255f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalPoints = (int)(sliders[0].value + sliders[1].value + sliders[2].value + sliders[3].value);
        pointsText.text = totalPoints.ToString();
        if(totalPoints > maxPoints)
        {
            pointsText.color = Color.red;
        }
        else if(totalPoints <= maxPoints)
        {
            pointsText.color = new Color(0.1960f, 0.1960f, 0.1960f, 1f);
        }
    }
}
