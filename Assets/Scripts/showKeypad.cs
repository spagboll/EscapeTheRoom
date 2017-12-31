using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class showKeypad : MonoBehaviour {

	public GameObject keypad;
	public GameObject player;
	// Use this for initialization
	void Start () {
	}

	public void ShowBigKeyPad(){
		keypad.SetActive (true);
		player.GetComponent<FirstPersonController>().enabled = false; 
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
