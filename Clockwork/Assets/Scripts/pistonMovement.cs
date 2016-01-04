using UnityEngine;
using System.Collections;

public class pistonMovement : MonoBehaviour 
{
	public float maxSpeed;
	public bool canMove;
	private Vector3 startPosition;
	
	// Use this for initialization
	void Start () {	
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update (){
		MoveVertical ();
	}
	
	void MoveVertical() {
		if (canMove) {
			transform.position = new Vector3 (transform.position.x, startPosition.y + Mathf.Sin (Time.time * maxSpeed), transform.position.z);
		
			if (transform.position.y > 1.0f) {
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			} else if (transform.position.y < -1.0f) {
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			}
		}
	}
}