using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChanges : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			transform.gameObject.tag = "Marked";
		}
	}
}
