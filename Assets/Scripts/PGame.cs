using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PGame : MonoBehaviour {

	public void LoadScene (){
		SceneManager.LoadScene(("Story_1"), LoadSceneMode.Single);
	}

}