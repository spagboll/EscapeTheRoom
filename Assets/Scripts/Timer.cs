using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public AudioSource audio;
	public AudioClip tickingSound;

	public Text timerText;
	public int timeLeft = 30;
	// Use this for initialization
	void Start () {
		//startTime = timerText;
		timerText.enabled = false;
	}

	public void StartTimer(){
	timerText.enabled = true;
	StartCoroutine("LoseTime");
	} 

	// Update is called once per frame
	void Update () {
		timerText.text = (timeLeft.ToString());

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
		}

	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			//play audio on each decrement
			audio.PlayOneShot(tickingSound);
			//wait for a second on each 
			yield return new WaitForSeconds(1);
			//decrement timer
			timeLeft--;
		}
	}
}
