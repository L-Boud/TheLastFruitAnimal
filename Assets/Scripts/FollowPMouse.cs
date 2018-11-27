﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPMouse : MonoBehaviour {

	public float Distance = 10;

	void Update()
	{
		Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 pos = r.GetPoint (Distance);
		transform.position = pos;
	}
}
