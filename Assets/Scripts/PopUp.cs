using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour {

	[SerializeField]
	Canvas messageCanvas;

	void Start ()
	{
		messageCanvas.enabled = false;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			TurnOnMessage ();
		}
	}

	private void TurnOnMessage()
	{
		messageCanvas.enabled = true;
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			TurnOffMessage ();
			Destroy (this.gameObject);
		}
	}

	private void TurnOffMessage ()
	{
		messageCanvas.enabled = false;
	}
}
		

