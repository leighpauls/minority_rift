using UnityEngine;
using System.Collections;

public class screen_selector : MonoBehaviour {

	SelectableScreen[] mScreens;
	int mSelectedScreen;
	GameObject Movie;
	GameObject ScreenStrm;
	GameObject CamPlane;
	const float yawToSelect = 20f;
	const float yawToLose = 40f;
	Vector3 mOrg, lOrg, rOrg;
	int LastHit; // 0 if hitting background, 1 if hitting screen, 2 if hitting movie
	float Incr;
	float dt = 0.03f;

	// Use this for initialization
	void Start () {
		LastHit = 0;
		Incr = 0;
		Movie = GameObject.Find ("movie_plane");
		ScreenStrm = GameObject.Find ("screen_plane");
		CamPlane = GameObject.Find ("camera_plane");
		rOrg = Movie.transform.position;
		lOrg = ScreenStrm.transform.position;
		mScreens = FindObjectsOfType<SelectableScreen>();
		Debug.Log ("Num screens: " + mScreens.Length);
		mSelectedScreen = -1;
		bool isSelected = false;
		bool isUnselected = true;
	}

	// Update is called once per frame
	void Update () {

		Vector3 fwd = Camera.main.transform.TransformDirection(Vector3.forward);
		bool isSelected = false;
		bool isUnselected = true;

		RaycastHit hit;
		if (Physics.Raycast (Camera.main.transform.position, fwd, out hit, 15)) {
			// hit.collider.gameObject.SendMessage ("SelectScreen");
			if (hit.collider.gameObject == Movie) {
				if ( LastHit != 2) {
					Incr = 0;
					LastHit = 2;
				}
				Movie.transform.position = Vector3.Lerp(Movie.transform.position, 0.6f*rOrg, Incr );
				Incr = Incr + dt;
				if (Incr >= 1)
					Incr = 1;
				ScreenStrm.transform.position = Vector3.Lerp(ScreenStrm.transform.position, lOrg, Incr );
				// Debug.Log ("Hit Movie!");
			} else if (hit.collider.gameObject == ScreenStrm) {
				if ( LastHit != 1) {
					Incr = 0;
					LastHit = 1;
				}
				ScreenStrm.transform.position = Vector3.Lerp(ScreenStrm.transform.position, 0.6f*lOrg, Incr );
				Incr = Incr + dt;
				if (Incr >= 1)
					Incr = 1;
				Movie.transform.position = Vector3.Lerp(Movie.transform.position, rOrg, Incr );
				// Debug.Log ("Hit Movie!");
			} else if (hit.collider.gameObject == CamPlane) {
				if ( LastHit != 0) {
					Incr = 0;
					LastHit = 0;
				}
				Incr = Incr + dt;
				if (Incr >= 1)
					Incr = 1;
				ScreenStrm.transform.position = Vector3.Lerp(ScreenStrm.transform.position, lOrg, Incr );
				Movie.transform.position = Vector3.Lerp(Movie.transform.position, rOrg, Incr );
				// Debug.Log ("Hit Movie!");
				// Debug.Log ("Hit Else");
			}
		}
	}
}
