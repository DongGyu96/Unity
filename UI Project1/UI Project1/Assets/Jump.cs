using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    float jumpspeed = 5.0f;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cubejump()
    {
        cube.GetComponent<Rigidbody>().velocity = Vector3.up * jumpspeed;
    }
}
