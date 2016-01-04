using UnityEngine;
using System.Collections;

public class transitionScript : MonoBehaviour {

	public GameObject player;
	private Animator playerAnimator;
	private bool pauseOver;

	void Start () {
		StartCoroutine ("pause");
		playerAnimator = player.GetComponent<Animator>();
	}

	void Update () {
		if (Application.loadedLevelName == "TitleScreen") {
			if (Input.anyKeyDown) {
				Application.LoadLevel ("Level Juan");
			}
		} 
		else if ((Application.loadedLevelName == "EndScreen") && pauseOver) {
			if (Input.anyKeyDown) {
				Application.LoadLevel ("Level Juan");
			}
		}
	}

	IEnumerator pause() {
		yield return new WaitForSeconds(1.5f);
		pauseOver = true;
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			if ((Application.loadedLevelName == "Level Juan") && !playerAnimator.GetBool("Dead")) {
				Application.LoadLevel("Level Too");
			}
			else if ((Application.loadedLevelName == "Level Too") && !playerAnimator.GetBool("Dead")) {
				Application.LoadLevel("Level tree");
			}
			else if ((Application.loadedLevelName == "Level tree") && !playerAnimator.GetBool("Dead")) {
				Application.LoadLevel("EndScreen");
			}
		}
	}
}
