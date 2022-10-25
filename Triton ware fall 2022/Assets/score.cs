using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class score : MonoBehaviour
{
    public double scoreMultiplier = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double newScore = Time.realtimeSinceStartup * scoreMultiplier;
        GetComponent<TextMeshProUGUI>().text = "Score: " + newScore.ToString().Substring(0, newScore.ToString().IndexOf('.'));
    }
}
