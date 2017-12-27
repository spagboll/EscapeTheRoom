using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideWelcomeText : MonoBehaviour {

	public float time = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("Hide", time); 
	}
	
	void Hide(){
		Destroy(gameObject);

	}
}
