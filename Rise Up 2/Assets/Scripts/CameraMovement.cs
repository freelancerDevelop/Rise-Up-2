using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float cameraSpeed = 0.04f;

	private void FixedUpdate () {
		Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y + cameraSpeed, Camera.main.transform.position.z);
	}

}