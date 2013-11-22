using UnityEngine;
using System.Collections;

public class RCamera : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		WebCamTexture cam = new WebCamTexture ();

		WebCamDevice[] devices = WebCamTexture.devices;
		for (int i = 0; i< devices.Length; i++) {
			if (devices[i].name.Contains("Microsoft")) {
				cam.deviceName = devices[i].name;
				break;
			}
		}
		renderer.material.mainTexture = cam;
		cam.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}