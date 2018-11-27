using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckVines01 : MonoBehaviour {

	public void CheckForEnemiesLeft()
	{
		if (GameObject.FindWithTag("Vine") == null)
		{
			SceneManager.LoadScene ("GameScene2");
		}
	}
}