using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {

	public Transform player;
	public GameObject playerObject;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
//		col = GetComponent<CapsuleCollider> ();
		//rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Vector3.Distance (player.position, this.transform.position) < 10) {
			
			Vector3 direction = player.position - this.transform.position; 
			direction.y = 0; 

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, 
				Quaternion.LookRotation (direction), 0.1f); 
			
			//anim.SetBool ("isIdle", false); 

			if (direction.magnitude > 5) {
				this.transform.Translate (0, 0, 0.05f);
				anim.SetBool ("isWalking", true);
				anim.SetBool ("isHitting", false); 
				anim.SetBool ("isIdle", false);

			
				Debug.Log ("Walking...");
			
			} else {
				anim.SetBool ("isHitting", true);
				Debug.Log ("Attacking!");
				//if (col.gameObject.tag.Equals ("Player")) {
				//	Debug.Log ("Collided with player");
				//}
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isIdle", false);

			}


			}
		else{
			
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isWalking", false); 
			anim.SetBool ("isHitting", false); 
		}
	}
//	void OnCollisionEnter(Collision collision){
////		if (collision.gameObject.tag == "PLayer") {
//		print("Collided with player");
//			//if (this.anim.GetAnimatorTransitionInfo (0).IsName ("Attack")) {
//			//	Debug.Log ("GAME OVER!");
//			//}
//
//		//}
//
//	}


//	void OnTriggerEnter(Collider col) {
//		if (col.gameObject.tag == "Player") {
//			
//			print ("i am a man");
//		}
//	}
}
