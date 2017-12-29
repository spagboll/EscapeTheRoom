using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showKeypad : MonoBehaviour {

	public GameObject keypad;
	// Use this for initialization
	void Start () {
	}

	public void ShowBigKeyPad(){
		keypad.SetActive (true);
	}
}
