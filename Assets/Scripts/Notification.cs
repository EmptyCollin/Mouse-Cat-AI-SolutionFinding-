﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeContent(string s) {
        GetComponent<Text>().text = s;
    }

    public void ChangeContent(string s,Color c)
    {
        GetComponent<Text>().text = s;
        GetComponent<Text>().color = c;
    }
}
