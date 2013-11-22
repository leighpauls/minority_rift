using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MovieTexture lame = renderer.material.mainTexture as MovieTexture;
		lame.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
