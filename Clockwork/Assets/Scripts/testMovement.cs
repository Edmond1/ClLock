using UnityEngine;
using System.Collections;

public class testMovement : MonoBehaviour {

	public float speed;
	public float jumpPower;

	public bool grounded;
	private bool canDoubleJump;

	private Rigidbody2D rb2D;
	private Animator animator;

	public bool canMove;

	void Start() {
		animator = gameObject.GetComponent<Animator>();
		rb2D = gameObject.GetComponent<Rigidbody2D>();
		canMove = true;
	}

	void Update() {
		animator.SetBool ("Grounded", grounded);
		animator.SetFloat ("H", Mathf.Abs(Input.GetAxis("Horizontal")));

		if ((Input.GetAxis ("Horizontal") < -0.1f) && canMove) {
			transform.localScale = new Vector3 (-0.35f, 0.35f, 0.35f);
		}

		if ((Input.GetAxis ("Horizontal") > 0.1f) && canMove) {
			transform.localScale = new Vector3 (0.35f, 0.35f, 0.35f);
		}

		if (((Input.GetKeyDown (KeyCode.UpArrow) && canMove)) || (Input.GetKeyDown (KeyCode.W) && canMove)) {
			if (grounded) {
				rb2D.isKinematic = false;
				rb2D.gravityScale = 1;
				rb2D.AddForce (Vector2.up * jumpPower);
				canDoubleJump = true;
				grounded = !grounded;
			}
			else {
				if (canDoubleJump) {
					rb2D.gravityScale = 1;
					canDoubleJump = false;
					rb2D.velocity = new Vector2 (rb2D.velocity.x, 0f);
					rb2D.AddForce (Vector2.up * jumpPower / 1.5f);
				}
			}
		}
	}

	void FixedUpdate() {
		float h = Input.GetAxis ("Horizontal");
		if (canMove) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 ((speed * h), GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}