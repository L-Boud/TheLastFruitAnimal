using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement02 : MonoBehaviour {
		public float speed;
		private Rigidbody rb;
		public Animator PlumMove;
		public bool PMoving = false;
		

		void Start ()
		{
			rb = GetComponent<Rigidbody>();
			PlumMove = GetComponent<Animator> ();
			
		}

		void FixedUpdate ()
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			Vector3 worldMovement = rb.transform.TransformVector (movement);
			rb.AddForce (worldMovement * speed);
			
		}

	void Update (){
		if (Mathf.Abs(rb.velocity.x) < 0.001) {
			PMoving = false;
		}
		else if (Mathf.Abs(rb.velocity.x) > 0.001) {
			PMoving = true;
		}
		PlumMove.SetBool ("Moving", PMoving);
	}
	}
