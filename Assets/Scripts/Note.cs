using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson; 

public class Note : MonoBehaviour {

	public Image noteImage;
	public GameObject hideNoteButton;
	public GameObject beginButton;

	public AudioClip pickupSound; 
	public AudioClip putAwaySound; 
	public GameObject playerObject;
	public GameObject timer;

	public GameObject note1;
	public GameObject note2;
	public GameObject note3;
	public GameObject note4;
	public GameObject keyNotes;



	// Use this for initialization
	void Start () {
		noteImage.enabled = false;
		hideNoteButton.SetActive(false);
		beginButton.SetActive (false);
		keyNotes.SetActive (false);
		}
	
	public void ShowNoteImage()
	{
		noteImage.enabled = true;
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);

		hideNoteButton.SetActive (true);
		beginButton.SetActive (true);

		playerObject.GetComponent<FirstPersonController>().enabled = false; 
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void HideNoteImage()
	{
		noteImage.enabled = false; 
		GetComponent<AudioSource> ().PlayOneShot (putAwaySound); 
		hideNoteButton.SetActive (false);
		beginButton.SetActive (false);

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true; 

		playerObject.GetComponent<FirstPersonController>().enabled = true; 
	}

	public void BeginChallenge(){
		this.HideNoteImage ();

		timer.GetComponent<Timer> ().StartTimer();
		keyNotes.SetActive (true);
	}
}
