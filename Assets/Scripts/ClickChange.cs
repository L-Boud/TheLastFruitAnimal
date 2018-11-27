using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickChange : MonoBehaviour {
	
	public PhysicMaterial material;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			print ("hi");
			material.bounciness = 1;
		}
	}
}
