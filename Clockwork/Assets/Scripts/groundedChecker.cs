using UnityEngine;
using System.Collections;

public class groundedChecker : MonoBehaviour {

	private testMovement ayy;
	private Rigidbody2D player;
	public bool notSpinning;

	void Start() {
		ayy = gameObject.GetComponentInParent<testMovement>();
		player = gameObject.GetComponentInParent<Rigidbody2D>();
		notSpinning = true;
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (notSpinning) {
			ayy.grounded = true;
			player.gravityScale = 0;
		}
	}

	void OnTriggerStay2D (Collider2D col) {
		if (notSpinning) {
			ayy.grounded = true;
			player.gravityScale = 0;
		}
	}

	void OnTriggerExit2D (Collider2D col) {
		if (notSpinning) {
			ayy.grounded = false;
			player.gravityScale = 1;
		}
	}
}
