using UnityEngine;
using System.Collections;

public class pistonHorizontal : MonoBehaviour {
	
		public float maxSpeed;
		public bool canMove;
		
		private Vector3 startPosition;
		
		// Use this for initialization
		void Start () {	
			startPosition = transform.position;
		}
		
		// Update is called once per frame
		void Update () {
			if (gameObject.GetComponent<Transform>().position.x == 2.246f) {
				canMove = !canMove;
			}
			MoveHorizontal();
		}
		
		void MoveHorizontal() {
		if (canMove) {
			transform.position = new Vector3 (startPosition.x + Mathf.Sin (Time.time * maxSpeed), transform.position.y, transform.position.z);
			if (gameObject.GetComponent<Transform>().position.x == 2.246f) {
				canMove = !canMove;
			}
		}
	}
	}
