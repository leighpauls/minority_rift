﻿using UnityEngine;
using System.Collections;

public class SetScreenImage : MonoBehaviour {
	
	// Use this for initialization
	void Start () {


		
		WebCamTexture cam = new WebCamTexture ();

		WebCamDevice[] devices = WebCamTexture.devices;
		for (int i = 0; i< devices.Length; i++) {
			Debug.Log(devices[i].name);
			if (devices[i].name.Contains("CamTwist")) {
				//Debug.Log (devices[i].name);
				cam.deviceName = devices[i].name;
				break;
			}
		}
		cam.mipMapBias = -0.5f;
		// renderer.material.mainTexture = cam;
		renderer.material.mainTexture = cam;
		cam.Play();
		
	}
	/*
	Texture2D mTexture;
	Color32[] mTextureBuffer;
	// Use this for initialization
	void Start () {
		mTexture = new Texture2D(400, 300);
		renderer.material.mainTexture = mTexture;
		mTextureBuffer = new Color32[mTexture.width*mTexture.height];
	}
	
	// Update is called once per frame
	void Update () {
		for (int y = 0; y < mTexture.height; ++y) {
			for (int x = 0; x < mTexture.width; ++x) {
				mTextureBuffer[(x + y * (mTexture.height))] = new Color32(
					(byte)(Random.value * 255f),
					(byte)(Random.value * 255f),
					(byte)(Random.value * 255f),
					128);
			}
		}
		mTexture.SetPixels32(mTextureBuffer);
		
		renderer.material.mainTexture = mTexture;
		
		mTexture.Apply();
	}*/
}
