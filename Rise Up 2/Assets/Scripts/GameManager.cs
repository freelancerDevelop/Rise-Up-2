using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	static public GameManager gm;
	public Vector4 cameraEdges;

	public LevelsManager lm;
	public Transform GameplayUI;

	private void Awake () {
		gm = this;

		cameraEdges = new Vector4 (
			Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 1, 0)).y,
			Camera.main.ViewportToWorldPoint (new Vector3 (1, 0.5f, 0)).x,
			Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0, 0)).y,
			Camera.main.ViewportToWorldPoint (new Vector3 (0, 0.5f, 0)).x
		);

		lm = GetComponent<LevelsManager> ();
		GameplayUI = transform.Find ("GameplayUI");
	}

}