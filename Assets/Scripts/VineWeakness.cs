using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineWeakness : MonoBehaviour {

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Marked") {
			Destroy (gameObject);
		}
	}
}