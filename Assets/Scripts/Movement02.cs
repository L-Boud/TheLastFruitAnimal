using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement02 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Animator PlumMove;
    public bool PMoving = false;
    float gravity = 9.81f;
	float reorientationTime = 1.0f;

    public void SwitchGravity(Vector3 direction)
    {
        Physics.gravity = direction * gravity;
		StartCoroutine(SwitchOrientation(-direction));
    }

	IEnumerator SwitchOrientation(Vector3 up)
	{
		SmoothMouseLook mouseLook = GetComponent<SmoothMouseLook>();
		mouseLook.enabled = false;
		Vector3 right = transform.right;
		Vector3 forward = Vector3.Cross(right, up);
		Quaternion start = transform.rotation;
		Quaternion end = Quaternion.LookRotation(forward, up);
		float time = 0.0f;
		float interpolation = 0.0f;
		while (interpolation < 1.0f)
		{
			time += Time.deltaTime;
			interpolation = Mathf.InverseLerp(0.0f, reorientationTime, time);
			transform.rotation = Quaternion.Slerp(start, end, interpolation);
			yield return null;
		}
		mouseLook.Reorient();
		mouseLook.enabled = true;
	}

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PlumMove = GetComponent<Animator>();
        Physics.gravity = Vector3.down * gravity;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 worldMovement = rb.transform.TransformVector(movement);
        rb.AddForce(worldMovement * speed);
    }

    void Update()
    {
        if (Mathf.Abs(rb.velocity.x) < 0.001)
        {
            PMoving = false;
        }
        else if (Mathf.Abs(rb.velocity.x) > 0.001)
        {
            PMoving = true;
        }
        PlumMove.SetBool("Moving", PMoving);
    }
}
