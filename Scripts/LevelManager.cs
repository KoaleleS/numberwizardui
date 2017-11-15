using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("Level load requsted for: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest () {
		Debug.Log("I Want to quit!");
		Application.Quit();
	}
}
