﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class uiScript : MonoBehaviour {

	public Button button1; 
	public Button button2; 
	public Button button3;
	public Button buttonG;
	public Button buttonPlus;
	public Button buttonMinus;

	public Camera cam;

	public Text ddvalue;
	public ColorBlock cselect;
	public ColorBlock cdesel;
	public Color selectColor;
	public Color deselectColor;

	// Use this for initialization
	void Start () {
		button1 = GameObject.Find("Key1").GetComponent<UnityEngine.UI.Button>();
		button2 = GameObject.Find("Key2").GetComponent<UnityEngine.UI.Button>();
		button3  = GameObject.Find("Key3").GetComponent<UnityEngine.UI.Button>();
		buttonG  = GameObject.Find("KeyG").GetComponent<UnityEngine.UI.Button>();
		buttonPlus = GameObject.Find("KeyPlus").GetComponent<UnityEngine.UI.Button>();
		buttonMinus = GameObject.Find("KeyMinus").GetComponent<UnityEngine.UI.Button>();
		ddvalue = GameObject.Find("DD Value").GetComponent<UnityEngine.UI.Text>();
		cam = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();

		cselect =  button1.colors;
		cdesel = button2.colors;


		selectColor = Color.yellow;
		deselectColor = Color.white;


		cselect.normalColor = selectColor;
		cdesel.normalColor = deselectColor;

		ddvalue.text = "10";

		//button2.colors = cselect;
	}
	
	// Update is called once per frame
	void Update () {
		
		//button2.colors = cselect;

		//button2.colors = cb;
		//button.colors = cb; 
		if(Input.GetKeyDown("1"))
		{
			button1.colors = cselect;
			button2.colors = cdesel;
			button3.colors = cdesel;
			buttonG.colors = cdesel;
			Application.LoadLevel ("sc1");

		}
		if(Input.GetKeyDown("2"))
		{
			button1.colors = cdesel;
			button2.colors = cselect;
			button3.colors = cdesel;
			buttonG.colors = cdesel;
			Application.LoadLevel ("sc2");
		}
		if(Input.GetKeyDown("3"))
		{
			button1.colors = cdesel;
			button2.colors = cdesel;
			button3.colors = cselect;
			buttonG.colors = cdesel;
			Application.LoadLevel ("TestingScene");
		}
		if(Input.GetKeyDown("g"))
		{
			button1.colors = cdesel;
			button2.colors = cdesel;
			button3.colors = cdesel;
			buttonG.colors = cselect;
			Application.LoadLevel ("goalScene");
		}
		if(Input.GetKeyDown("=")|| Input.GetKeyDown("+"))
		{
			buttonPlus.colors = cselect;

			int val = Convert.ToInt32 (ddvalue.text);
			val += 1;
			ddvalue.text = val.ToString();
			button1.colors = cdesel;
			button2.colors = cdesel;
			button3.colors = cdesel;
			buttonG.colors = cdesel;
			buttonMinus.colors = cdesel;

			cam.farClipPlane = val;
		}

		if(Input.GetKeyDown("-")|| Input.GetKeyDown("_"))
		{
			buttonMinus.colors = cselect;
			int val = Convert.ToInt32 (ddvalue.text);
			if (val > 1) {
				val -= 1;
			}
			ddvalue.text = val.ToString();
			button1.colors = cdesel;
			button2.colors = cdesel;
			button3.colors = cdesel;
			buttonG.colors = cdesel;
			buttonPlus.colors = cdesel;

			cam.farClipPlane = val;
		}


	}

}
