using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceChange : MonoBehaviour {

	public BoxCollider playercoll;
	public PhysicMaterial material;
	public Transform target;
	public Collider col;

	void OnCollisonEnter (Collision col)
	{
		if (col.gameObject.tag == "Green")
		{
			print ("hoi");
			playercoll = GetComponent<BoxCollider>();
			material.bounciness = 1;
			playercoll.material = material;
		}
		
	}
}

