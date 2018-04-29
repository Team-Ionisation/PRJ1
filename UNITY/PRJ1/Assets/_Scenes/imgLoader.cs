using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class imgLoader : MonoBehaviour {
	public Texture aTexture;
	// Use this for initialization
	void Start () {
		
		 

	}
	
	void OnGUI() {
		if (!aTexture) {
			Debug.LogError ("Assign a Texture in the inspector.");
			return;
		}
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), aTexture, ScaleMode.ScaleToFit, true, 0);
	}
	void Update () {
	 
	}
}
