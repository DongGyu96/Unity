using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CSInput : MonoBehaviour
{
    Text txt;
    InputField input1;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("txCenter").GetComponent<Text>();
        input1 = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void ChangeText()
    {
        if(input1.text.Length <= 3)
        {
            if(EditorUtility.DisplayDialog("알람", "입력은 3자 이상으로 해주세요.", "확인"))
            {
                input1.Select();
            }
        }
        else
        {
             txt.text = input1.text;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
