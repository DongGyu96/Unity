using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSSlider : MonoBehaviour
{
    Text txt;
    Slider slider1;
    Slider slider2;
    int FontSize;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("txCenter").GetComponent<Text>();
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        FontSize = txt.fontSize;
    }

    public void ChangeSliderValue()
    {
        float val = slider2.value;
        slider1.value = val;
        txt.fontSize = FontSize * (int)val;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
