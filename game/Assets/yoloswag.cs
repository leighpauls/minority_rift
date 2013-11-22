using UnityEngine;
using System.Collections;

public class yoloswag : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		WebCamTexture cam = new WebCamTexture ();

		WebCamDevice[] devices = WebCamTexture.devices;
		cam.deviceName = devices[1].name;
		for (int i =0; i< devices.Length; i++) {
			print (devices[i].name);
		}
		renderer.material.mainTexture = cam;
		cam.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
