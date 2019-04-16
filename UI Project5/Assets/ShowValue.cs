using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    public void UpdateLabel(float value)
    {
        Text lb1 = GetComponent<Text>();
        if(lb1 != null)
        {
            lb1.text = Mathf.RoundToInt(value * 10) + "%";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
