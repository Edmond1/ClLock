using UnityEngine;
using System.Collections;

public class dankSecretCheck : MonoBehaviour {

	public GameObject glasses;
	public GameObject boxArt;

	private SpriteRenderer gRenderer;
	private SpriteRenderer bRenderer;

	void Start () {
		gRenderer = glasses.GetComponent<SpriteRenderer>();
		bRenderer = boxArt.GetComponent<SpriteRenderer>();
	}


	void Update () {
		if (obligatorySecret.dankSecret) {
			gRenderer.sortingOrder = 1;
			bRenderer.sortingOrder = 1;
		}
	}
}
