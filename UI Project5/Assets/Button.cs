using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    GameObject obj;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("txCenter");
        txt = obj.GetComponent<Text>();     // obj의 컴포넌트중 Text의 모든것을 가져옴
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        txt.text = "홍길동";
    }
}
