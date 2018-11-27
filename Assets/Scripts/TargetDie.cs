using UnityEngine;
using System.Collections;

public class TargetDie : MonoBehaviour {

	void OnCollisionEnter (Collision col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.tag == "Green") {
			Destroy (gameObject);
		}
	}
}
