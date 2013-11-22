using UnityEngine;
using System.Collections;

public class yolo : MonoBehaviour {

	// Use this for initialization
	void Start () {

		WebCamTexture cam = new WebCamTexture ();
		renderer.material.mainTexture = cam;
		cam.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
