﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public int souls=0;
    public TMP_Text soulsText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soulsText.text = "Souls : " + souls;
        if (souls == 10)
        {
            SceneManager.LoadScene(4);
        }
    }
}
