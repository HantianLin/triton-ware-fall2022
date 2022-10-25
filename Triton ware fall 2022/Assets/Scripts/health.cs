using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class health : MonoBehaviour
{
    public int Health = 100;
    
    public void subtractHealth(int value)
    {
        Health -= value;
    }   

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Health: " + Health.ToString();
    }
}
