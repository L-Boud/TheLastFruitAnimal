using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour {
	
	public float BounceStart = 0.5f;
	public float BounceGreen = 1;
	public PhysicMaterial material;
	public Color colour;
	public string marker;
	public GameObject Slider;
	public Slider PowrDow;
	public float PowrTim;
	public bool Power;
	float powrMax;
	GameObject target;

	void Awake () 
	{
		material.bounciness = BounceStart;
	}
	void Start (){
		Slider.SetActive (false);
		powrMax = PowrTim;
	}
		
	void Update()
	{
		PowrDow.value -= Time.deltaTime;
		if (target != null && PowrDow.value <= 0 && Power == false) {
			Slider.SetActive (false);
			Power = true;
			RestoreSettings ();

		}
	}

	void OnCollisionEnter (Collision col)
	{
		PowrDow.maxValue = powrMax;
		target = col.gameObject;
		Power = true;
		Slider.SetActive (true);
		PowrDow.value = PowrTim;
		Power = false;
		col.gameObject.GetComponentInChildren<Renderer> ().material.color = colour;	
		material.bounciness = 1;
		col.transform.gameObject.tag = marker;
		Jumping jumping = col.gameObject.GetComponent<Jumping> ();
		if (jumping != null) {
			jumping.PowerUp (true);
		}
	}

	void RestoreSettings()
	{
		target.GetComponentInChildren<Renderer> ().material.color = Color.white;	
		material.bounciness = 0;
		target.tag = "Player";
		Jumping jumping = target.GetComponent<Jumping> ();
		if (jumping != null) {
			jumping.PowerUp (false);
		}
		target = null;
	}
}
