using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMovement : MonoBehaviour {

	private Vector2 mousePos;
	private Rigidbody2D rb;

	private Vector2 offsetClicked;
	private Vector2 offsetReleased;

	private void Start () {
		rb = GetComponent<Rigidbody2D> ();
		offsetReleased = transform.position;
	}

	private void FixedUpdate () {
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		if (Input.GetMouseButton (0)) {
			Vector2 newPos = new Vector2 (
				Mathf.Clamp(mousePos.x + offsetClicked.x, GameManager.gm.cameraEdges.w + 0.32f, GameManager.gm.cameraEdges.y - 0.32f),
				mousePos.y + offsetClicked.y
			);

			rb.MovePosition (newPos);
			offsetReleased = newPos - (Vector2) Camera.main.transform.position;
		} //Clicked
		else {
			Vector2 newPos = new Vector2 (
				Mathf.Clamp (Camera.main.transform.position.x + offsetReleased.x, GameManager.gm.cameraEdges.w + 0.32f, GameManager.gm.cameraEdges.y - 0.32f),
				Camera.main.transform.position.y + offsetReleased.y
			);

			rb.MovePosition (newPos);
			offsetClicked = newPos - mousePos;
		} //Released
	}

}