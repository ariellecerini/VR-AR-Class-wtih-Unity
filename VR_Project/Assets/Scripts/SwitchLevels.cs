﻿using UnityEngine.SceneManagement; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  	void OnTriggerEnter ()
  	{
  		SceneManager.LoadScene(1);
  	}

  	
}
