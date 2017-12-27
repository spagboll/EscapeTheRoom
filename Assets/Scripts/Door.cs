using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	//initally set to false as door by default will be closed
	//set to true when we want to open the door
	public bool doorOpen = false;

	public float openAngle = 90f;
	public float closedAngle = 0f;

	//speed of door rotation
	public float smooth = 2f;

	public void ChangeDoorState()
	{
		doorOpen = !doorOpen;
	}

	// Update is called once per frame
	void Update () {

		if (doorOpen) {

			Quaternion targetRotation = Quaternion.Euler (0, openAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth * Time.deltaTime);

		} else {

			Quaternion targetRotation = Quaternion.Euler (0, closedAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth * Time.deltaTime);
		
		}

	}
}
