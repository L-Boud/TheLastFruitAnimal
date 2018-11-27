using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class POptions : MonoBehaviour {

	public void LoadScene (){
		SceneManager.LoadScene(("Options"), LoadSceneMode.Single);
	}
}