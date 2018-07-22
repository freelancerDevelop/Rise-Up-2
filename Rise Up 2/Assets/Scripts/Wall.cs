using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	private void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Obstacle") {
			Destroy (other.gameObject);
		}
	}

}