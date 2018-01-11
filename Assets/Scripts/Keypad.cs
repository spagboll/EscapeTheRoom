using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Keypad : MonoBehaviour {


	public GameObject player;
	private string keyCode = "9999";
	private string keyInput = string.Empty;


	//public LayerMask interactLayer;


	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
//		player.GetComponent<FirstPersonController>().enabled = false; 
//
//
//		Cursor.lockState = CursorLockMode.None;
//		Cursor.visible = true;
	}

	// Update is called once per frame
	void Update () {

}
	//https://docs.unity3d.com/ScriptReference/RectTransform.html
	public void CheckClick(RectTransform rectT){
		
		Debug.Log (rectT.name);
		if (keyInput.Length < 4) {
			if (rectT.name == "Button0") {
				keyInput += "0";
				Debug.Log (keyInput);

			}
			if (rectT.name == "Button1") {
				keyInput += "1";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button2") {
				keyInput += "2";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button3") {
				keyInput += "3";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button4") {
				keyInput += "4";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button5") {
				keyInput += "5";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button6") {
				keyInput += "6";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button7") {
				keyInput += "7";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button8") {
				keyInput += "7";
				Debug.Log (keyInput);
			}
			if (rectT.name == "Button9") {
				keyInput += "9";
				Debug.Log (keyInput);
			}
		}
	}

	public void CheckInput(){
	
		if (keyInput.Equals(keyCode)) {
			
			Debug.Log ("Correct combination");
		}
	}
}
	