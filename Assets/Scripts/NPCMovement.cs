using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour {
	Transform player; 
	NavMeshAgent nav; 
	Animator anim;
	Collider NPCCollider;

	// Use this for initialization
	void Start () {
		
	}

	void Awake (){
		player = GameObject.FindGameObjectWithTag("Player").transform; 
		nav = GetComponent<NavMeshAgent>(); 
		anim = GetComponent<Animator> ();
		//NPCCollider = GetComponent<CapsuleCollider>; 
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			nav.SetDestination (player.position);
			anim.SetBool ("isWalking", true);
			anim.SetBool ("isIdle", false);
			//anim.SetBool ("isHitting", false);
		} else {
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isHitting", false);
		}



	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag.Equals ("Player")) {
			anim.SetBool ("isHitting", true);
			Debug.Log ("COLLIDING!"); 
		}
	}

	void OnCollisionExit(Collision collision){
		anim.SetBool ("isHitting", false); 
	}

}
