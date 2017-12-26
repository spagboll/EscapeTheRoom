using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	public int distanceToItem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.Collect (); 
	}

	void Collect(){
		if (Input.GetKey("e")) {
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast (ray, out hit, distanceToItem)) {
				if (hit.collider.gameObject.name == "item")
					Debug.Log ("item hit");
				
				else if (hit.collider.CompareTag ("Note")) {
					hit.collider.GetComponent<Note> ().ShowNoteImage (); 	
				}
			}
		}
	}
}
