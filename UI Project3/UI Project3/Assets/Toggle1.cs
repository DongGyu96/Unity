using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toggle1 : MonoBehaviour
{
    Text txt;
    Toggle tgChange;
    GameObject txtobj;
    GameObject tgobj;
    // Start is called before the first frame update
    void Start()
    {
        txtobj = GameObject.Find("txCenter");
        tgobj = GameObject.Find("tgChange");
        tgChange = tgobj.GetComponent<Toggle>();
        txt = txtobj.GetComponent<Text>();
        ChangeText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        if(!tgChange.isOn)
        {
            txt.text = "hello world";
        }
        else
        {
            txt.text = "홍길동";
        }
    }
}
