using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class VideoLoader : MonoBehaviour {
	public VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		Debug.Log (videoPlayer.time);
		if (videoPlayer.time > 4) {
			SceneManager.LoadScene ("l2");
			Debug.Log ("CHANGED SCENE");		} else {
			//do nothing
		}
	}
}