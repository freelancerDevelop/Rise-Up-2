using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {

	private BoxCollider2D Wall1;
	private BoxCollider2D Wall2;
	private BoxCollider2D Wall3;

	private void Start () {
		Wall1 = transform.Find ("Wall1").GetComponent<BoxCollider2D> ();
		Wall2 = transform.Find ("Wall2").GetComponent<BoxCollider2D> ();
		Wall3 = transform.Find ("Wall3").GetComponent<BoxCollider2D> ();

		Wall1.offset = new Vector2 (GameManager.gm.cameraEdges.y + 0.5f, GameManager.gm.cameraEdges.z);
		Wall2.offset = new Vector2 (0, GameManager.gm.cameraEdges.z * 3);
		Wall3.offset = new Vector2 (GameManager.gm.cameraEdges.w - 0.5f, GameManager.gm.cameraEdges.z);

		Wall1.size = new Vector2 (1, Camera.main.orthographicSize * 4);
		Wall2.size = new Vector2 (Camera.main.orthographicSize * Camera.main.aspect * 2 + 2, 1);
		Wall3.size = new Vector2 (1, Camera.main.orthographicSize * 4);
	}

}