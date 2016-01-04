using UnityEngine;
using System.Collections;

public class gearRotation : MonoBehaviour {

	public float rotationSpeed;
	private Transform transform;
	public bool canRotate;

	void Start() {
		transform = GetComponent<Transform>();
	}

	void Update () {
		if (canRotate) {
			transform.Rotate (0, 0, (rotationSpeed * Time.deltaTime));
		}
	}

}
