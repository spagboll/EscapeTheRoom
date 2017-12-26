using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson; 

public class Note : MonoBehaviour {

	public Image noteImage;
	public GameObject hideNoteButton;

	public AudioClip pickupSound; 
	public AudioClip putAwaySound; 
	public GameObject playerObject;


	// Use this for initialization
	void Start () {
		noteImage.enabled = false;
		hideNoteButton.SetActive (false);
		}
	
	public void ShowNoteImage()
	{
		noteImage.enabled = true;
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);

		hideNoteButton.SetActive (true);
		playerObject.GetComponent<FirstPersonController>().enabled = false; 

		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void HideNoteImage()
	{
		noteImage.enabled = false; 
		GetComponent<AudioSource> ().PlayOneShot (putAwaySound); 
		hideNoteButton.SetActive (false);

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true; 

		playerObject.GetComponent<FirstPersonController>().enabled = true; 
	}
}
