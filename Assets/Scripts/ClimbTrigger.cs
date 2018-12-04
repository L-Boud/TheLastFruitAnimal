using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour
{
	void OnTriggerEnter(Collider collider)
	{
		Movement02 player = collider.GetComponent<Movement02>();
		if (player != null)
		{
			player.SwitchGravity(-transform.up);
		}
	}
}
