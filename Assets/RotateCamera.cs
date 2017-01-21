using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal");
		if (rotation != 0.0f) {
			transform.Rotate (0, rotation, 0);
		}
	}
}
