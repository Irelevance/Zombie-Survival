﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public delegate void InputResponse();
    public delegate void ButtonDownResponse(bool isButtonHeldDown);

    public event ButtonDownResponse isPressingAim;
    public event InputResponse onWeaponPrimary;
	
	// Update is called once per frame
	void Update () {
	    
        if(Input.GetMouseButtonDown(0)) { 
            onWeaponPrimary();
        }

        if(isPressingAim != null)
            isPressingAim(Input.GetMouseButton(1));
	}
}