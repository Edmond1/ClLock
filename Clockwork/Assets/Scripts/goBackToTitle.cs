using UnityEngine;
using System.Collections;

public class goBackToTitle : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Application.LoadLevel("TitleScreen");
		}
	}
}
