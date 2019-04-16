using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    GameObject obj;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("txCenter");
        txt = obj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeText()
    {
        txt.text = "ABCD";
    }
}
