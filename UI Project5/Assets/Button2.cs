using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    GameObject obj;
    Text txt;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        obj = GameObject.Find("txCenter");
        txt = obj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeText()
    {
        count++;
        txt.text = "\t  " + count;
    }
}
