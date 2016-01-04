using UnityEngine;
using System.Collections;

public class screwScript3 : MonoBehaviour {
	
	public GameObject longPiston;
	private pistonMovement pisMov;
	
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
		pisMov = longPiston.GetComponent<pistonMovement>();
		screwPos = gameObject.GetComponent<Transform>();
		screwAnimator = gameObject.GetComponent<Animator>();
		playerPos = player.GetComponent<Transform>();
		startPosition = transform.position;
		shmoundShmeck = groundCheck.GetComponent<groundedChecker>();
	}
	
	void OnTriggerEnter2D (Collider2D col) {
		playerAnimator.SetBool ("Spinning", true);
		screwAnimator.SetBool ("Down", true);
		shmoundShmeck.notSpinning = false;
		StartCoroutine("wait");
	}
	
	IEnumerator wait () {
		player.GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, 0f);
		player.GetComponent<Rigidbody2D>().gravityScale = 1;
		playerMovement.canMove = false;
		playerPos.position = new Vector3 (0.87f, -1.015f, 0f);
		yield return new WaitForSeconds(1f);
		screwAnimator.SetBool ("Down", false);
		playerAnimator.SetBool ("Spinning", false);
		pisMov.canMove = true;
		playerMovement.canMove = true;
		shmoundShmeck.notSpinning = true;
		Destroy (gameObject);
	}
}
