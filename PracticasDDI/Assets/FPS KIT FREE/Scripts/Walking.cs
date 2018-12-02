﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	 void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("walkman2");
        }
	}
}
