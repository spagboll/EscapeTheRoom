using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Keypad : MonoBehaviour {


	public GameObject player;
	private string keyCode = "9999";

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
	}

	public void CheckInput(){
	
	
	}
}
	