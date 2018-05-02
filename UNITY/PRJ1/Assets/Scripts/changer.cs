using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour {
	public string TargetScene;
	public Color loadToColour = Color.white;

	// Use this for initialization
	void Start () {
		StartCoroutine (wait ());
	}



// Update is called once per frame
	IEnumerator wait() {
	 Debug.Log ("SCENE for 5s");
	 yield return new WaitForSeconds(5);
	 Initiate.Fade (TargetScene, loadToColour, 2f);


}
	// Update is called once per frame
	void Update () {
		
	}
}
