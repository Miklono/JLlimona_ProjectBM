using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSliderValueTest : MonoBehaviour
{
    //Variables
    public Slider slider;
    public Text textSlideValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textSlideValue.text = slider.value.ToString("0");
    }
}
