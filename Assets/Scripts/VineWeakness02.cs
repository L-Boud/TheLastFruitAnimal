using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineWeakness02 : MonoBehaviour {

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Marked2") {
			Destroy (gameObject);
		}
	}
}