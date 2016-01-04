using UnityEngine;
using System.Collections;

public class grimReaper : MonoBehaviour {

	public bool conditionJuan;
	public bool conditionToo;

	public GameObject player;
	private Animator playerAnimator;

	private bool conditionTree;

	void Start() {
		playerAnimator = player.GetComponent<Animator>();
	}

	void Update() {
		if (conditionJuan && conditionToo) {
			//Debug.Log ("Grim Reaper part one works");
			playerAnimator.SetBool("Dead", true);
			StartCoroutine("waitMan");
		}
		if (playerAnimator.GetBool("Dead") && conditionTree) {
			//Debug.Log ("Grim Reaper part two works");
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	IEnumerator waitMan() {
		yield return new WaitForSeconds(1);
		conditionTree = true;
	}
}
