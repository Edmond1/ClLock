using UnityEngine;
using System.Collections;

public class bypassPiston : MonoBehaviour {

	public GameObject player;
	private Rigidbody2D playerRB;
	private testMovement playerMovement;

	void Start() {
		playerRB = player.GetComponent<Rigidbody2D>();
		playerMovement = player.GetComponent<testMovement>();
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			playerRB.isKinematic = true;
			if (((Input.GetKeyDown (KeyCode.UpArrow) && playerMovement.canMove)) || (Input.GetKeyDown (KeyCode.W) && playerMovement.canMove)) {
				playerRB.isKinematic = false;
				playerRB.gravityScale = 1;
				playerMovement.grounded = false;
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			playerRB.isKinematic = false;
			playerRB.gravityScale = 1;
			playerMovement.grounded = false;
		}
	}

}
