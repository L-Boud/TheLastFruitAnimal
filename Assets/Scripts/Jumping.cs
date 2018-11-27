using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

	public int forceConst = 50;
	private bool powerJump = false;
	private bool canJump;
	private Rigidbody selfRigidBody;
	public Rigidbody rb;
	public float disToGround;

	void Start (){
		selfRigidBody = GetComponent <Rigidbody> ();
		//get distance to ground

	}

	public void PowerUp(bool active)
	{
		powerJump = active;
	}

	bool IsGrounded () {
		return Physics.Raycast (transform.position, Physics.gravity.normalized, disToGround + 0.1f);
	}

	void FixedUpdate (){
		if (canJump) {
			canJump = false;
			rb.velocity = Vector3.zero;
			rb.AddForce (Physics.gravity.normalized * (powerJump? forceConst * 1.6f : forceConst), ForceMode.Impulse);
		}
	}

	void Update (){
		if (Input.GetKeyUp (KeyCode.Space) && IsGrounded()){
			canJump = true;
		}
	}
}


