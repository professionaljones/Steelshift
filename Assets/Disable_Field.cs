﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Field : MonoBehaviour {

    public GameObject FF1;
    public GameObject FF2;
    public Animator FA1;
    public Animator FA2;


    // Use this for initialization
    void Start () {

        FA1 = FF1.GetComponent<Animator>();
        FA2 = FF2.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetButtonDown("Interact"))
            {
                if(FA1.GetBool("Disabled") == false)
                {
                    FA1.SetBool("Disabled", true);
                    FA2.SetBool("Disabled", true);
                }
            }
        }
    }
}