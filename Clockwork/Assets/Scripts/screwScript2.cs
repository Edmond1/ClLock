using UnityEngine;
using System.Collections;

public class screwScript2 : MonoBehaviour {

		public GameObject piston;
		private Animator pistonAnimator;
		
		private Transform screwPos;
		private bool down;
		
		public GameObject player;
		private Animator playerAnimator;
		
		private Animator screwAnimator;
		
		private Transform playerPos;
		
		private testMovement playerMovement;
		
		private Vector3 startPosition;
		
		public GameObject groundCheck;
		private groundedChecker shmoundShmeck;
		
		void Start () {
			playerMovement = player.GetComponent<testMovement>();
			playerAnimator = player.GetComponent<Animator>();
			pistonAnimator = piston.GetComponent<Animator>();
			screwPos = gameObject.GetComponent<Transform>();
			screwAnimator = gameObject.GetComponent<Animator>();
			playerPos = player.GetComponent<Transform>();
			startPosition = transform.position;
			shmoundShmeck = groundCheck.GetComponent<groundedChecker>();
		}
		
		void OnTriggerEnter2D (Collider2D col) {
			playerAnimator.SetBool ("Spinning", true);
			screwAnimator.SetBool ("Down", true);
			pistonAnimator.SetBool ("canMove", true);
			shmoundShmeck.notSpinning = false;
			StartCoroutine("wait");
		}
		
		IEnumerator wait () {
			player.GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, 0f);
			player.GetComponent<Rigidbody2D>().gravityScale = 1;
			playerMovement.canMove = false;
			playerPos.position = new Vector3 (1.98f, -1f, 0f);
			yield return new WaitForSeconds(1f);
			screwAnimator.SetBool ("Down", false);
			playerAnimator.SetBool ("Spinning", false);
			pistonAnimator.SetBool ("canMove", false);
			playerMovement.canMove = true;
			shmoundShmeck.notSpinning = true;
			Destroy (gameObject);
		}
	}
