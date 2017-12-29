﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Interact : MonoBehaviour {

	public string interactButton;
    public float interactDistance = 3f;
	public LayerMask interactLayer;

	public Image interactIcon; 

	public bool isInteracting; 



	// Use this for initialization
	void Start () {
		if (interactIcon != null) {
			interactIcon.enabled = false; 
		}
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward); 
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 
			    interactDistance, interactLayer)) {

			if (!isInteracting) {

				if (interactIcon != null) {
					interactIcon.enabled = true;
				}
				if (Input.GetButtonDown (interactButton)) {
					if (hit.collider.CompareTag ("Note")) {
						hit.collider.GetComponent<Note> ().ShowNoteImage ();
						interactIcon.enabled = false;

					}
					if (hit.collider.CompareTag ("Keypad")) {
						//hit.collider.GetComponent<Keypad> ().ShowKeypad ();.
						hit.collider.GetComponent<showKeypad>().ShowBigKeyPad();
						interactIcon.enabled = false;
					
					}
				}

			}
		} else {
			interactIcon.enabled = false;
		}
	}
}
