using UnityEngine;
using System.Collections;

public class becomeChildOnCollision : MonoBehaviour {

	private gearRotation metalGear;
	private float playerRotateSpeed;
	private GameObject player;
	private testMovement pMovement;

	void Start() {
		metalGear = gameObject.GetComponent<gearRotation>();
		playerRotateSpeed = -metalGear.rotationSpeed;
		player = GameObject.FindGameObjectWithTag("Player");
		pMovement = player.GetComponent<testMovement>();
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Player" && (metalGear.canRotate)) {
			col.transform.parent = gameObject.transform;
			col.transform.Rotate (0, 0, (playerRotateSpeed * Time.deltaTime));
			pMovement.grounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			col.transform.parent = null;
			col.transform.rotation = Quaternion.identity;
			pMovement.grounded = false;
		}
	}
}
