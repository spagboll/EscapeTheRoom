using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Keypad : MonoBehaviour {

//	public GameObject button1;
//	public GameObject button2;
//	public GameObject button3;
//	public GameObject button4;
//	public GameObject button5;
//	public GameObject button6;
//	public GameObject button7;
//	public GameObject button8;
//	public GameObject button9;
//	public GameObject button0;
	public GameObject player;

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
//		if (Input.GetMouseButtonDown(0)) {
//			RaycastHit hit;
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			if (Physics.Raycast(ray, out hit)) {
//				if (hit.transform.name == "Button0")
//				{
//				 Debug.Log ("Button0 pressed");
//				}
//			}
//		}
}
		
	public void CheckClick(RectTransform rectT){
		
		Debug.Log (rectT.name);
	}
}
	