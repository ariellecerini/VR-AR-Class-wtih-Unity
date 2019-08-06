﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	//list variables 
	public float speed = 1f; //variable for speed of pacman movement 
	public GameObject spawn_1; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
        	transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter (Collider gate)
    {
    	if (gate.gameObject.tag == "Gate_1")

    	{
    		transform.position = spawn_1.transform.position; 

    	}


    }
}
